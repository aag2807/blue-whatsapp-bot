using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class ErrorScenarioTests : BaseStateTest
{
    #region Database Failure Tests

    [Test]
    public async Task HotelSelectionState_WhenRepositoryThrowsException_ShouldReturnNull()
    {
        // Arrange
        var state = new HotelSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.HotelSelection;
        context.ZoneId = "1";

        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(It.IsAny<int>()))
            .ThrowsAsync(new InvalidOperationException("Database connection failed"));

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task ZoneSelectionState_WhenRepositoryThrowsException_ShouldReturnNull()
    {
        // Arrange
        var state = new ZoneSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneSelection;

        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(It.IsAny<int>()))
            .ThrowsAsync(new TimeoutException("Database timeout"));

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task ZoneUnknownState_WhenRepositoryThrowsException_ShouldReturnNull()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ThrowsAsync(new Exception("Repository error"));

        // Act
        var result = await state.Process(context, "Hotel Name");

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WhenRepositoryThrowsException_ShouldReturnNull()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = "1|2";

        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(It.IsAny<int>()))
            .ThrowsAsync(new InvalidOperationException("Database error"));

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Null);
    }

    #endregion

    #region Service Unavailable Tests

    [Test]
    public async Task HotelSelectionState_WhenHotelNotFound_ShouldStayInSameState()
    {
        // Arrange
        var state = new HotelSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.HotelSelection;
        context.ZoneId = "1";

        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync((CoreHotel?)null); // Hotel not found
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(1))
            .ReturnsAsync(new List<CoreHotel> { CreateTestHotel(2, "Other Hotel", 0) });

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.HotelSelection));
    }

    [Test]
    public async Task ZoneSelectionState_WhenNoHotelsInZone_ShouldStillTransition()
    {
        // Arrange
        var state = new ZoneSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneSelection;

        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(1))
            .ReturnsAsync(new List<CoreHotel>()); // Empty list

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.HotelSelection));
        Assert.That(context.ZoneId, Is.EqualTo("1"));
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WhenSelectedHotelNotFound_ShouldTransitionToManualHandling()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = "1|2";

        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync((CoreHotel?)null); // Hotel not found

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ManualHandling));
        Assert.That(context.IsAdminOverridden, Is.True);
    }

    #endregion

    #region Context Corruption Tests

    [Test]
    public async Task HotelSelectionState_WithNullZoneId_ShouldHandleGracefully()
    {
        // Arrange
        var state = new HotelSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.HotelSelection;
        context.ZoneId = null!; // Corrupted context

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneSelection)); // Should go back to zone selection
    }

    [Test]
    public async Task HotelSelectionState_WithInvalidZoneId_ShouldHandleGracefully()
    {
        // Arrange
        var state = new HotelSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.HotelSelection;
        context.ZoneId = "invalid"; // Non-numeric zone ID

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneSelection)); // Should go back to zone selection
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WithCorruptedExtraInformation_ShouldTransitionToManualHandling()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = "invalid|data|format"; // Corrupted pipe string

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ManualHandling));
        Assert.That(context.IsAdminOverridden, Is.True);
    }

    #endregion

    #region Memory/Performance Edge Cases

    [Test]
    public async Task ZoneUnknownState_WithVeryLongHotelName_ShouldHandleGracefully()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        var veryLongHotelName = new string('A', 1000); // 1000 character hotel name
        var testHotel = CreateTestHotel(1, "Test Hotel", 0);
        
        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ReturnsAsync(new List<CoreHotel> { testHotel });

        // Act
        var result = await state.Process(context, veryLongHotelName);

        // Assert
        Assert.That(result, Is.Not.Null);
        // Should transition to manual handling since no match will be found
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ManualHandling));
    }

    [Test]
    public async Task ZoneUnknownState_WithManyHotels_ShouldHandlePerformance()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        // Create a large list of hotels to test performance
        var manyHotels = new List<CoreHotel>();
        for (int i = 1; i <= 1000; i++)
        {
            manyHotels.Add(CreateTestHotel(i, $"Hotel {i}", 0));
        }
        
        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ReturnsAsync(manyHotels);

        // Act
        var result = await state.Process(context, "Hotel 500");

        // Assert
        Assert.That(result, Is.Not.Null);
        // Should find the matching hotel
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        Assert.That(context.HotelId, Is.EqualTo("500"));
    }

    #endregion

    #region Special Character and Encoding Tests

    [TestCase("José María", true)] // Spanish characters
    [TestCase("François", true)] // French characters  
    [TestCase("José's Hotel & Resort", true)] // Special characters
    [TestCase("Hotel@Example.com", true)] // Email-like characters
    [TestCase("Hotel #1 (Best)", true)] // Numbers and symbols
    [TestCase("🏨 Hotel", true)] // Emoji characters
    public async Task AskForRoomNumberState_WithSpecialCharacters_ShouldHandleCorrectly(string input, bool shouldBeValid)
    {
        // Arrange
        var state = new AskForRoomNumberState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldBeValid && input.Trim().Length >= 2)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
            Assert.That(context.FullName, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
        }
    }

    [TestCase("101A", true)] // Alphanumeric room
    [TestCase("Presidential Suite", true)] // Text room number
    [TestCase("Rm-205", true)] // Room with dash
    [TestCase("Floor 3, Room 12", true)] // Complex room description
    [TestCase("", false)] // Empty room number
    public async Task AskForAdultsState_WithVariousRoomNumbers_ShouldHandleCorrectly(string input, bool shouldBeValid)
    {
        // Arrange
        var state = new AskForAdultsState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForAdults;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldBeValid)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
            Assert.That(context.RoomNumber, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
        }
    }

    #endregion

    #region Concurrent Access Tests

    [Test]
    public async Task MultipleStates_ProcessingSimultaneously_ShouldHandleIndependently()
    {
        // Arrange
        var state1 = new AskForChildrenState();
        var state2 = new AskForPhoneState();
        
        var context1 = CreateTestConversationState();
        context1.CurrentStep = ConversationStep.AskForChildren;
        context1.UserNumber = "User1";
        
        var context2 = CreateTestConversationState();
        context2.CurrentStep = ConversationStep.AskForPhone;
        context2.UserNumber = "User2";

        // Act - Process both states simultaneously
        var task1 = state1.Process(context1, "5"); // Valid adults count
        var task2 = state2.Process(context2, "2"); // Valid children count
        
        var results = await Task.WhenAll(task1, task2);

        // Assert
        Assert.That(results[0], Is.Not.Null);
        Assert.That(results[1], Is.Not.Null);
        
        Assert.That(context1.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        Assert.That(context1.Adults, Is.EqualTo(5));
        
        Assert.That(context2.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
        Assert.That(context2.Children, Is.EqualTo(2));
    }

    #endregion
}
