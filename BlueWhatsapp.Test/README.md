# BlueWhatsapp Chatbot Test Suite

This comprehensive test suite validates the multilingual WhatsApp chatbot's state machine flow and WhatsApp integration.

## Test Structure

### 📁 StateTests/
Individual state behavior validation with comprehensive input validation testing.

- **BaseStateTest.cs** - Base test class with common mocks and test data
- **WelcomeStateTests.cs** - Welcome message and initial transition
- **LanguageSelectionStateTests.cs** - Language validation (1-6) with fallback to Spanish
- **DateSelectionStateTests.cs** - Date parsing validation with multiple formats
- **ZoneSelectionStateTests.cs** - Zone selection with "I don't know" handling
- **HotelSelectionStateTests.cs** - Hotel selection with VIP vs Free service detection
- **VipServiceConfirmationStateTests.cs** - VIP service acceptance with Bayahibe special handling
- **UserInformationStatesTests.cs** - Complete user data collection flow validation
- **ReservationCompleteStateTests.cs** - Email validation and reservation creation

### 📁 IntegrationTests/
End-to-end conversation flow testing.

- **ConversationFlowIntegrationTests.cs** - Complete conversation flows:
  - Free service flow (Welcome → Reservation Complete)
  - VIP service flow (with service confirmation)
  - Bayahibe VIP flow (with group size selection)

### 📁 ServiceTests/
Service layer and WhatsApp integration testing.

- **ChatResponseServiceTests.cs** - WhatsApp message handling:
  - New user creation
  - Existing user flow
  - Admin override handling
  - Message sending and saving
- **ConversationHandlingServiceTests.cs** - State machine orchestration:
  - State transitions
  - Error handling
  - Invalid state management

## Key Testing Features

### 🎯 Mocking Strategy
- **Moq Framework** - Complete mocking of all external dependencies
- **Service Provider Mocking** - Repository and service layer isolation
- **WhatsApp Service Mocking** - Message sending verification without external calls

### ✅ Validation Coverage
- **Input Validation** - All user inputs validated with edge cases
- **State Transitions** - Proper flow between conversation states
- **Error Handling** - Graceful handling of invalid inputs
- **Business Logic** - VIP vs Free service routing, Bayahibe special handling

### 🔄 Flow Testing
- **Complete Flows** - Full conversation journeys from start to finish
- **Branch Testing** - Different paths (VIP, Free, Bayahibe)
- **Edge Cases** - Invalid inputs, missing data, error scenarios

## Running Tests

```bash
# Run all tests
dotnet test

# Run specific test category
dotnet test --filter "Category=StateTests"
dotnet test --filter "Category=IntegrationTests"
dotnet test --filter "Category=ServiceTests"

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## Test Data

### Mock Hotels
- **Free Service Hotels** - Price = 0, direct to schedule selection
- **VIP Service Hotels** - Price > 0, requires VIP confirmation
- **Bayahibe Hotels** - Special group size selection flow

### Mock Conversation Contexts
- **Standard Flow** - Regular user journey
- **Admin Override** - Manual handling scenarios
- **Multi-language** - Language selection validation

## Assertions

### State Validation
```csharp
Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ExpectedState));
Assert.That(context.LanguageId, Is.EqualTo("1")); // Spanish default
Assert.That(context.IsComplete, Is.True); // Reservation completion
```

### Mock Verification
```csharp
MockMessageCreator.Verify(mc => mc.CreateWelcomeMessage(userNumber), Times.Once);
MockWhatsappService.Verify(ws => ws.SendMessage(It.IsAny<CoreBaseMessage>()), Times.Once);
MockReservationRepository.Verify(rr => rr.SaveReservation(It.IsAny<CoreReservation>()), Times.Once);
```

## Coverage Goals

- ✅ **95%+ State Coverage** - All conversation states tested
- ✅ **90%+ Input Validation** - All user inputs validated  
- ✅ **100% Critical Paths** - Main conversation flows covered
- ✅ **85%+ Error Scenarios** - Edge cases and error handling

## Continuous Integration

These tests are designed to run in CI/CD pipelines with:
- Fast execution (no external dependencies)
- Reliable assertions (deterministic test data)
- Clear failure messages (descriptive test names)
- Comprehensive coverage (all business logic paths)
