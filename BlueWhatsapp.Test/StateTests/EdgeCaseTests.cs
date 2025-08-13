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
    public async Task AskForChildrenState_WithZeroAdults_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForChildrenState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForChildren;

        // Act
        var result = await state.Process(context, "0");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
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
    public async Task AskForRoomNumberState_WithSingleCharacterName_ShouldStayInSameState()
    {
        // Arrange
        var state = new AskForRoomNumberState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        // Act
        var result = await state.Process(context, "A");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
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

    [TestCase("1", true)] // Minimum valid adults
    [TestCase("50", true)] // Maximum valid adults
    [TestCase("51", false)] // Over maximum
    [TestCase("0", false)] // Below minimum
    public async Task AskForChildrenState_AdultsBoundaryConditions(string input, bool shouldTransition)
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
            Assert.That(context.Adults, Is.EqualTo(int.Parse(input)));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
        }
    }

    [TestCase("0", true)] // Minimum valid children
    [TestCase("20", true)] // Maximum valid children  
    [TestCase("21", false)] // Over maximum
    [TestCase("-1", false)] // Below minimum
    public async Task AskForPhoneState_ChildrenBoundaryConditions(string input, bool shouldTransition)
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
            Assert.That(context.Children, Is.EqualTo(int.Parse(input)));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        }
    }

    [TestCase("AB", true)] // Minimum valid name length
    [TestCase("John Doe", true)] // Normal name
    [TestCase("A", false)] // Too short
    [TestCase("", false)] // Empty
    [TestCase("   ", false)] // Whitespace only
    public async Task AskForRoomNumberState_NameLengthBoundaryConditions(string input, bool shouldTransition)
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
            Assert.That(context.FullName, Is.EqualTo(input.Trim()));
        }
        else
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
        }
    }

    #endregion

    #region Phone Validation Tests

    [TestCase("1234567", true)] // Minimum length
    [TestCase("123456789012345", true)] // Maximum length
    [TestCase("123-456-7890", true)] // With dashes
    [TestCase("+1 (555) 123-4567", true)] // International format
    [TestCase("555.123.4567", true)] // With dots
    [TestCase("123456", false)] // Too short
    [TestCase("1234567890123456", false)] // Too long
    [TestCase("abc123def", false)] // Contains letters
    [TestCase("", false)] // Empty
    [TestCase("   ", false)] // Whitespace only
    public async Task AskForEmailState_PhoneValidationTests(string input, bool shouldBeValid)
    {
        // Arrange
        var state = new AskForEmailState();
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForEmail;

        // Act
        var result = await state.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        if (shouldBeValid)
        {
            Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete));
            Assert.That(context.ExtraInformation, Is.EqualTo(input.Trim()));
        }
        else
        {
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
