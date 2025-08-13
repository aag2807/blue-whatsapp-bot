namespace BlueWhatsapp.Core.Utils;

public static class PipeStringHelper
{
    public static string PipeStringFromCollection<T>(IEnumerable<T> collection)
    {
        return string.Join("|", collection);
    }

    public static List<string> PipeStringToList(string pipeString)
    {
        return pipeString.Split("|").ToList();
    }

    public static List<int> PipeStringToIntList(string pipeString)
    {
        return pipeString.Split("|")
            .Where(s => int.TryParse(s, out _))
            .Select(int.Parse)
            .ToList();
    }
}