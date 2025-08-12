using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class HotelSelectionStateTests : BaseStateTest
{
    private HotelSelectionState _hotelSelectionState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _hotelSelectionState = new HotelSelectionState();
    }

    [Test]
    public async Task Process_WithIDontKnowOption_ShouldTransitionToHotelUnknown()
    {
        // Arrange
        var context = CreateTestConversationState();
        var userMessage = "99"; // I don't know option

        // Act
        var result = await _hotelSelectionState.Process(context, userMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.HotelUnknown));
        MockMessageCreator.Verify(mc => mc.CreateUnknownHotelMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    public async Task Process_WithValidHotelId_AndFreeService_ShouldTransitionToScheduleSelection()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.ZoneId = "1";
        var hotelId = "1";
        var hotel = CreateTestHotel(1, "Free Hotel", 0); // Free service
        var schedules = new List<CoreSchedule> { CreateTestSchedule() };
        
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1))
            .ReturnsAsync(schedules);

        // Act
        var result = await _hotelSelectionState.Process(context, hotelId);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.HotelId, Is.EqualTo(hotelId));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        MockMessageCreator.Verify(mc => mc.CreateTimeFrameSelectionMessage(
            context.UserNumber, hotel, schedules, 1), Times.Once);
    }

    [Test]
    public async Task Process_WithValidHotelId_AndVipService_ShouldTransitionToVipServiceOffer()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.ZoneId = "1";
        var hotelId = "1";
        var hotel = CreateTestHotel(1, "VIP Hotel", 20); // VIP service
        
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(hotel);

        // Act
        var result = await _hotelSelectionState.Process(context, hotelId);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.HotelId, Is.EqualTo(hotelId));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.VipServiceOffer));
        MockMessageCreator.Verify(mc => mc.CreateVipServiceOfferMessage(
            context.UserNumber, hotel, 1), Times.Once);
    }

    [Test]
    public async Task Process_WithNonExistentHotelId_ShouldAskForHotelSelectionAgain()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.ZoneId = "1";
        var hotelId = "999";
        var hotels = new List<CoreHotel> { CreateTestHotel() };
        
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(999))
            .ReturnsAsync((CoreHotel?)null);
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(1))
            .ReturnsAsync(hotels);

        // Act
        var result = await _hotelSelectionState.Process(context, hotelId);

        // Assert
        Assert.That(result, Is.Not.Null);
        MockMessageCreator.Verify(mc => mc.CreateHotelSelectionMessage(
            context.UserNumber, hotels, 1), Times.Once);
    }

    [Test]
    [TestCase("0")]
    [TestCase("-1")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task Process_WithInvalidHotelId_ShouldAskForHotelSelectionAgain(string invalidHotelId)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.ZoneId = "1";
        var hotels = new List<CoreHotel> { CreateTestHotel() };
        
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(1))
            .ReturnsAsync(hotels);

        // Act
        var result = await _hotelSelectionState.Process(context, invalidHotelId);

        // Assert
        Assert.That(result, Is.Not.Null);
        MockMessageCreator.Verify(mc => mc.CreateHotelSelectionMessage(
            context.UserNumber, hotels, 1), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeHotelSelection()
    {
        // Assert
        Assert.That(_hotelSelectionState.StateId, Is.EqualTo(ConversationStep.HotelSelection));
    }
}
