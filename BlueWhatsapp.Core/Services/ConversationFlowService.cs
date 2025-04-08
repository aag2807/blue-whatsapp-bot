using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace BlueWhatsapp.Core.Services
{
    public sealed class ConversationFlowService : IConversationFlowService
    {
        private readonly ConversationFlowOptions _options;
        private readonly Dictionary<string, string> _defaultResponses;

        public ConversationFlowService(IOptions<ConversationFlowOptions> options)
        {
            _options = options.Value;

            // Initialize default responses for fallback
            _defaultResponses = new Dictionary<string, string>
            {
                { "error", "Lo siento, ha ocurrido un error. Por favor, intente de nuevo." },
                {
                    "timeout",
                    "Parece que ha pasado un tiempo desde su última interacción. ¿Desea continuar con su reserva?"
                }
            };
        }

        /// <summary>
        /// Gets the response template for the specified conversation step
        /// </summary>
        string IConversationFlowService.GetResponseForStep(ConversationStep step,
            Dictionary<string, string> parameters = null)
        {
            string stepName = step.ToString();

            if (!_options.Steps.TryGetValue(stepName, out var stepConfig) || string.IsNullOrEmpty(stepConfig.Response))
            {
                return _defaultResponses["error"];
            }

            string responseTemplate = stepConfig.Response;

            // Replace parameters in the template
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    responseTemplate = responseTemplate.Replace($"{{{param.Key}}}", param.Value);
                }
            }

            return responseTemplate;
        }

        /// <summary>
        /// Determines the next step based on current step and user input
        /// </summary>
        ConversationStep IConversationFlowService.GetNextStep(ConversationStep currentStep, string userInput)
        {
            string stepName = currentStep.ToString();

            if (!_options.Steps.TryGetValue(stepName, out var stepConfig))
            {
                return currentStep; // Stay on current step if config not found
            }

            // If no options defined for this step, use the default next step
            if (stepConfig.Options == null || !stepConfig.Options.Any())
            {
                if (!string.IsNullOrEmpty(stepConfig.DefaultNextStep) &&
                    Enum.TryParse<ConversationStep>(stepConfig.DefaultNextStep, out var nextStep))
                {
                    return nextStep;
                }

                return currentStep;
            }

            // Try to match user input with an option
            foreach (var option in stepConfig.Options)
            {
                string value = option.Value;
                string title = option.Title;

                // Match by exact value, contains the title, or contains the value
                if (userInput.Equals(value, StringComparison.OrdinalIgnoreCase) ||
                    (title != null && userInput.Contains(title, StringComparison.OrdinalIgnoreCase)) ||
                    (value != null && userInput.Contains(value, StringComparison.OrdinalIgnoreCase)))
                {
                    if (Enum.TryParse<ConversationStep>(option.NextStep, out var matchedNextStep))
                    {
                        return matchedNextStep;
                    }
                }
            }

            // If no match found, use fallback next step or stay on current step
            if (!string.IsNullOrEmpty(stepConfig.FallbackNextStep) &&
                Enum.TryParse<ConversationStep>(stepConfig.FallbackNextStep, out var fallbackStep))
            {
                return fallbackStep;
            }

            return currentStep;
        }

        /// <summary>
        /// Checks if the current step is expecting a specific data format
        /// </summary>
        bool IConversationFlowService.ValidateInput(ConversationStep step, string userInput, out string errorMessage)
        {
            string stepName = step.ToString();

            if (!_options.Steps.TryGetValue(stepName, out var stepConfig) || stepConfig.Validation == null)
            {
                errorMessage = null;
                return true; // No validation rules, input is valid
            }

            string validationType = stepConfig.Validation.Type;
            string pattern = stepConfig.Validation.Pattern;
            string errorMsg = stepConfig.Validation.ErrorMessage ?? "Input is not valid.";

            bool isValid = true;

            switch (validationType)
            {
                case "regex":
                    if (!string.IsNullOrEmpty(pattern) &&
                        !System.Text.RegularExpressions.Regex.IsMatch(userInput, pattern))
                    {
                        isValid = false;
                    }

                    break;

                case "date":
                    if (!DateTime.TryParse(userInput, out _))
                    {
                        isValid = false;
                    }

                    break;

                case "number":
                    if (!int.TryParse(userInput, out _))
                    {
                        isValid = false;
                    }

                    break;

                case "email":
                    // Simple email validation
                    if (!userInput.Contains("@") || !userInput.Contains("."))
                    {
                        isValid = false;
                    }

                    break;
            }

            errorMessage = isValid ? null : errorMsg;
            return isValid;
        }
    }
}