using BlueWhatsapp.Core.Enums;

namespace BlueWhatsapp.Core.Services;

public interface IConversationFlowService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="step"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public string GetResponseForStep(ConversationStep step, Dictionary<string, string> parameters = null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="currentStep"></param>
    /// <param name="userInput"></param>
    /// <returns></returns>
    public ConversationStep GetNextStep(ConversationStep currentStep, string userInput);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="step"></param>
    /// <param name="userInput"></param>
    /// <param name="errorMessage"></param>
    /// <returns></returns>
    public bool ValidateInput(ConversationStep step, string userInput, out string errorMessage);
}