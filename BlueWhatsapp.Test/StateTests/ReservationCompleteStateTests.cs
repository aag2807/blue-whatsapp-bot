using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class ReservationCompleteStateTests : BaseStateTest
{
    private ReservationCompleteState _reservationCompleteState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _reservationCompleteState = new ReservationCompleteState();
    }

    [Test]
    [TestCase("user@example.com")]
    [TestCase("test.email+tag@domain.co.uk")]
    [TestCase("simple@test.org")]
    public async Task Process_WithValidEmail_ShouldCreateReservationAndComplete(string validEmail)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.HotelId = "1";
        context.ScheduleId = "1";
        context.ZoneId = "1";
        context.FullName = "John Doe";
        context.RoomNumber = "101";
        context.Adults = 2;
        context.Children = 1;
        context.PickUpDate = "2025-08-15";

        var hotel = CreateTestHotel();
        var schedule = CreateTestSchedule();

        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetScheduleByIdAsync(1))
            .ReturnsAsync(schedule);
        MockReservationRepository.Setup(rr => rr.SaveReservation(It.IsAny<CoreReservation>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await _reservationCompleteState.Process(context, validEmail);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.Email, Is.EqualTo(validEmail.Trim().ToLower()));
        Assert.That(context.IsComplete, Is.True);
        
        MockReservationRepository.Verify(rr => rr.SaveReservation(It.Is<CoreReservation>(r =>
            r.UserNumber == context.UserNumber &&
            r.Username == context.FullName &&
            r.RoomNumber == context.RoomNumber &&
            r.AdultsCount == context.Adults &&
            r.ChildrenCount == context.Children &&
            r.Email == context.Email
        )), Times.Once);

        MockMessageCreator.Verify(mc => mc.CreateReservationConfirmationMessage(
            context.UserNumber, hotel, schedule, context.PickUpDate, 1), Times.Once);
    }

    [Test]
    [TestCase("invalid-email")]
    [TestCase("@domain.com")]
    [TestCase("user@")]
    [TestCase("")]
    [TestCase("plaintext")]
    [TestCase("user@domain")]
    public async Task Process_WithInvalidEmail_ShouldAskForEmailAgain(string invalidEmail)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _reservationCompleteState.Process(context, invalidEmail);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete)); // Should stay in same state
        Assert.That(context.IsComplete, Is.False);
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
        MockReservationRepository.Verify(rr => rr.SaveReservation(It.IsAny<CoreReservation>()), Times.Never);
    }

    [Test]
    public void StateId_ShouldBeReservationComplete()
    {
        // Assert
        Assert.That(_reservationCompleteState.StateId, Is.EqualTo(ConversationStep.ReservationComplete));
    }
}
