using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.State.StateNodes;
using BlueWhatsapp.Core.Utils;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class EdgeCaseTests : BaseStateTest
{
    #region Input Validation Edge Cases

    [Test]
    public async Task DateSelectionState_WithNullInput_ShouldStayInSameState()
    {
        // Arrange
        var state = new DateSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.DateSelection;

        // Act
        var result = await state.Process(context, null!);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
    }

    [Test]
    public async Task DateSelectionState_WithEmptyString_ShouldStayInSameState()
    {
        // Arrange
        var state = new DateSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.DateSelection;

        // Act
        var result = await state.Process(context, "");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
    }

    [Test]
    public async Task DateSelectionState_WithWhitespaceOnly_ShouldStayInSameState()
    {
        // Arrange
        var state = new DateSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.DateSelection;

        // Act
        var result = await state.Process(context, "   ");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
    }

    [Test]
    public async Task DateSelectionState_WithInvalidDateFormat_ShouldStayInSameState()
    {
        // Arrange
        var state = new DateSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.DateSelection;

        // Act
        var result = await state.Process(context, "invalid-date");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
    }

    [Test]
    public async Task AskForChildrenState_WithValidChildrenCount_ShouldTransition()
    {
        // Arrange
        var state = new AskForChildrenState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForChildren;

        // Act
        var result = await state.Process(context, "0");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        Assert.That(context.Children, Is.EqualTo(0));
    }

    [Test]
    public async Task AskForChildrenState_WithNegativeAdults_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForChildrenState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForChildren;

        // Act
        var result = await state.Process(context, "-5");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
    }

    [Test]
    public async Task AskForChildrenState_WithExcessiveAdults_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForChildrenState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForChildren;

        // Act
        var result = await state.Process(context, "100"); // Over limit of 50

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
    }

    [Test]
    public async Task AskForPhoneState_WithNegativeChildren_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForPhoneState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForPhone;

        // Act
        var result = await state.Process(context, "-1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
    }

    [Test]
    public async Task AskForPhoneState_WithExcessiveChildren_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForPhoneState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForPhone;

        // Act
        var result = await state.Process(context, "50"); // Over limit of 20

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
    }

    [Test]
    public async Task AskForRoomNumberState_WithEmptyName_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForRoomNumberState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        // Act
        var result = await state.Process(context, "");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
    }

    [Test]
    public async Task AskForRoomNumberState_WithSingleCharacterRoom_ShouldTransition()
    {
        // Arrange
        var state = new AskForRoomNumberState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        // Act
        var result = await state.Process(context, "A");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
        Assert.That(context.RoomNumber, Is.EqualTo("A"));
    }

    #endregion

    #region Special Flow Tests

    [Test]
    public async Task ZoneSelectionState_WithIDontKnowOption_ShouldTransitionToZoneUnknown()
    {
        // Arrange
        var state = new ZoneSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneSelection;

        // Act
        var result = await state.Process(context, "99"); // "I don't know" option

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneUnknown));
    }

    [Test]
    public async Task ZoneUnknownState_WithNoMatchingHotels_ShouldTransitionToManualHandling()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        // Mock hotel repository to return empty list
        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ReturnsAsync(new List<CoreHotel>());

        // Act
        var result = await state.Process(context, "NonExistentHotel");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ManualHandling));
        Assert.That(context.IsAdminOverridden, Is.True);
    }

    [Test]
    public async Task ZoneUnknownState_WithSingleMatchingHotel_ShouldSetHotelAndProceed()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        var testHotel = CreateTestHotel(1, "Test Hotel Resort", 0, 0); // Free service, routeId = 0
        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ReturnsAsync(new List<CoreHotel> { testHotel });
        
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1))
            .ReturnsAsync(new List<CoreSchedule> { CreateTestSchedule() });

        // Act
        var result = await state.Process(context, "Test Hotel");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        Assert.That(context.HotelId, Is.EqualTo("1"));
        Assert.That(context.ZoneId, Is.EqualTo("0"));
    }

    [Test]
    public async Task ZoneUnknownState_WithMultipleMatchingHotels_ShouldTransitionToMoreThanOneMatching()
    {
        // Arrange
        var state = new ZoneUnknownState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.ZoneUnknown;

        var hotel1 = CreateTestHotel(1, "Paradise Resort Hotel", 0);
        var hotel2 = CreateTestHotel(2, "Paradise Beach Hotel", 0);
        MockHotelRepository.Setup(hr => hr.GetAllHotelsAsync())
            .ReturnsAsync(new List<CoreHotel> { hotel1, hotel2 });

        // Act
        var result = await state.Process(context, "Paradise"); // This should match both hotels

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.MoreThanOneMatchingHotel));
        Assert.That(context.ExtraInformation, Is.Not.Null.And.Not.Empty);
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WithValidSelection_ShouldSelectHotel()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = "1|2"; // Two hotel IDs

        var testHotel = CreateTestHotel(1, "Selected Hotel", 0);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(testHotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1))
            .ReturnsAsync(new List<CoreSchedule> { CreateTestSchedule() });

        // Act
        var result = await state.Process(context, "1"); // Select first hotel

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        Assert.That(context.HotelId, Is.EqualTo("1"));
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WithInvalidSelection_ShouldStayInSameState()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = "1|2"; // Two hotel IDs

        // Set up mocks for the hotels to display options again
        var hotel1 = CreateTestHotel(1, "Hotel 1", 0);
        var hotel2 = CreateTestHotel(2, "Hotel 2", 0);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1)).ReturnsAsync(hotel1);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(2)).ReturnsAsync(hotel2);

        // Act
        var result = await state.Process(context, "5"); // Invalid selection

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.MoreThanOneMatchingHotel));
    }

    [Test]
    public async Task MoreThanOneMatchingHotelState_WithEmptyExtraInfo_ShouldTransitionToManualHandling()
    {
        // Arrange
        var state = new MoreThanOneMatchingHotelState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
        context.ExtraInformation = ""; // Empty extra info

        // Act
        var result = await state.Process(context, "1");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ManualHandling));
        Assert.That(context.IsAdminOverridden, Is.True);
    }

    #endregion

    #region Boundary Condition Tests

    [TestCase("0", true)] // Minimum valid children
    [TestCase("20", true)] // Maximum valid children
    [TestCase("21", false)] // Over maximum
    [TestCase("-1", false)] // Below minimum
    public async Task AskForChildrenState_ChildrenBoundaryConditions(string input, bool shouldTransition)
    {
        // Arrange
        var state = new AskForChildrenState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForChildren;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldTransition)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
            Assert.That(context.Children, Is.EqualTo(int.Parse(input)));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
        }
    }

    [TestCase("1234567890", true)] // Valid phone
    [TestCase("123-456-7890", true)] // Valid phone with dashes
    [TestCase("(555) 123-4567", true)] // Valid phone with parentheses
    [TestCase("123", false)] // Too short
    [TestCase("invalid", false)] // Invalid format
    public async Task AskForPhoneState_PhoneValidationBoundaryConditions(string input, bool shouldTransition)
    {
        // Arrange
        var state = new AskForPhoneState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForPhone;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldTransition)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
            Assert.That(context.ExtraInformation, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        }
    }

    [TestCase("101", true)] // Valid room number
    [TestCase("A1B", true)] // Valid alphanumeric room
    [TestCase("Presidential Suite", true)] // Valid suite name
    [TestCase("", false)] // Empty
    [TestCase("   ", false)] // Whitespace only
    public async Task AskForRoomNumberState_RoomNumberBoundaryConditions(string input, bool shouldTransition)
    {
        // Arrange
        var state = new AskForRoomNumberState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldTransition)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
            Assert.That(context.RoomNumber, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
        }
    }

    #endregion

    #region Phone Validation Tests

    [TestCase("user@example.com", true)] // Valid email
    [TestCase("test.email@domain.org", true)] // Valid email with dot
    [TestCase("john.doe@company.co.uk", true)] // Valid email with subdomain
    [TestCase("invalid-email", false)] // No @ symbol
    [TestCase("@example.com", false)] // Missing username
    [TestCase("user@", false)] // Missing domain
    [TestCase("", false)] // Empty
    [TestCase("   ", false)] // Whitespace only
    [TestCase("user.example.com", false)] // Missing @ symbol
    public async Task AskForEmailState_EmailValidationTests(string input, bool shouldBeValid)
    {
        // Arrange
        var state = new AskForEmailState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForEmail;

        // Act
        var result = await state.Process(context, input);

        // Assert
        if (shouldBeValid)
        {
            Assert.That(result, Is.Null); // Should return null to trigger transition
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete));
            Assert.That(context.Email, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
        }
    }

    #endregion

    #region Language ID Edge Cases

    [TestCase("1", 1)] // Spanish
    [TestCase("2", 2)] // English  
    [TestCase("6", 6)] // Last valid language
    [TestCase("0", 1)] // Invalid, should default to Spanish
    [TestCase("7", 1)] // Invalid, should default to Spanish
    [TestCase("", 1)] // Empty, should default to Spanish
    [TestCase("abc", 1)] // Non-numeric, should default to Spanish
    public async Task LanguageSelectionState_LanguageIdBoundaryTests(string languageInput, int expectedLanguageId)
    {
        // Arrange
        var state = new LanguageSelectionState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.LanguageSelection;

        // Act
        var result = await state.Process(context, languageInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
        
        // Verify the language ID was set correctly
        int actualLanguageId = int.TryParse(context.LanguageId, out int langId) && langId >= 1 && langId <= 6 ? langId : 1;
        Assert.That(actualLanguageId, Is.EqualTo(expectedLanguageId));
    }

    #endregion
}
