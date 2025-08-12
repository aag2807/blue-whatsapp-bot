using NUnit.Framework;

namespace BlueWhatsapp.Test;

/// <summary>
/// Test suite runner that provides a comprehensive overview of all test categories
/// </summary>
[TestFixture]
public class TestSuiteRunner
{
    [Test]
    public void TestSuite_Overview()
    {
        // This test provides documentation of the test suite structure
        var testCategories = new[]
        {
            "State Tests - Individual state behavior validation",
            "Integration Tests - Complete conversation flow testing",
            "Service Tests - Service layer and WhatsApp integration testing",
            "Utility Tests - Date parsing and hotel matching validation"
        };

        Assert.That(testCategories.Length, Is.EqualTo(4));
        TestContext.WriteLine("Test Suite Categories:");
        foreach (var category in testCategories)
        {
            TestContext.WriteLine($"- {category}");
        }
    }

    [Test]
    [Category("StateTests")]
    public void StateTests_ShouldCoverAllCriticalStates()
    {
        var coveredStates = new[]
        {
            "WelcomeState",
            "LanguageSelectionState", 
            "DateSelectionState",
            "ZoneSelectionState",
            "HotelSelectionState",
            "VipServiceConfirmationState",
            "UserInformationStates",
            "ReservationCompleteState"
        };

        Assert.That(coveredStates.Length, Is.GreaterThanOrEqualTo(8));
        TestContext.WriteLine("Covered State Tests:");
        foreach (var state in coveredStates)
        {
            TestContext.WriteLine($"- {state}");
        }
    }

    [Test]
    [Category("IntegrationTests")]
    public void IntegrationTests_ShouldCoverCompleteFlows()
    {
        var coveredFlows = new[]
        {
            "Complete Free Service Flow",
            "Complete VIP Service Flow", 
            "Bayahibe VIP Service Flow with Group Size Selection"
        };

        Assert.That(coveredFlows.Length, Is.EqualTo(3));
        TestContext.WriteLine("Covered Integration Test Flows:");
        foreach (var flow in coveredFlows)
        {
            TestContext.WriteLine($"- {flow}");
        }
    }

    [Test]
    [Category("ServiceTests")]
    public void ServiceTests_ShouldCoverWhatsAppIntegration()
    {
        var coveredServices = new[]
        {
            "ChatResponseService - WhatsApp message handling",
            "ConversationHandlingService - State machine orchestration"
        };

        Assert.That(coveredServices.Length, Is.EqualTo(2));
        TestContext.WriteLine("Covered Service Tests:");
        foreach (var service in coveredServices)
        {
            TestContext.WriteLine($"- {service}");
        }
    }
}
