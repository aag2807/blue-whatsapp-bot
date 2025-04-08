namespace BlueWhatsapp.Core.Models;

public class ConversationFlowOptions
{
    public Dictionary<string, StepConfig> Steps { get; set; } = new();
}

public class StepConfig
{
    public string Response { get; set; }
    public string DefaultNextStep { get; set; }
    public string FallbackNextStep { get; set; }
    public List<OptionConfig> Options { get; set; } = new();
    public ValidationConfig Validation { get; set; }
}

public class OptionConfig
{
    public string Title { get; set; }
    public string Value { get; set; }
    public string NextStep { get; set; }
}

public class ValidationConfig
{
    public string Type { get; set; }
    public string Pattern { get; set; }
    public string ErrorMessage { get; set; }
}