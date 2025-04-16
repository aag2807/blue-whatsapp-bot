using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Test;

[TestFixture]
public class DateParserTest
{
    private readonly DateParser _parser = new();

    [Test]
    public void DateParserShould_BeAbleToParseDate_WhenDateIsInCorrectFormat()
    {
        string date = "15 de Agosto";

        string parsedDate = _parser.TryParseDate(date);
        
        Assert.That(parsedDate, Is.Not.EqualTo(date));
        Assert.That(parsedDate, Is.Not.Null);
        Assert.That(parsedDate, Is.Not.Empty);
        Assert.That(parsedDate, Is.EqualTo("2025-08-15"));
    }

    [Test]
    public void DateParserShould_ParseMultipleDateFormatsAndEndWithSameResult()
    {
        string date = "15 de Agosto";
        string date2 = "15 de Agosto de 2025";
        string date3 = "15 de Agosto 2025";
        string date4 = "15 de Agosto, 2025";
        string date5 = "15/08/2025";
        string date6 = "15-08-2025";
        
        string result1 = _parser.TryParseDate(date);
        string result2 = _parser.TryParseDate(date2);
        string result3 = _parser.TryParseDate(date3);
        string result4 = _parser.TryParseDate(date4);
        string result5 = _parser.TryParseDate(date5);
        string result6 = _parser.TryParseDate(date6);
        
        Assert.That(result1, Is.EqualTo("2025-08-15"));
        Assert.That(result2, Is.EqualTo("2025-08-15"));
        Assert.That(result3, Is.EqualTo("2025-08-15"));
        Assert.That(result4, Is.EqualTo("2025-08-15"));
        Assert.That(result5, Is.EqualTo("2025-08-15"));
        Assert.That(result6, Is.EqualTo("2025-08-15"));
    }
    
    [Test]
    public void DateParserShould_BeAbleToParseDate_WhenDateIsInCorrectFormatAndReturnDateTimeObject()
    {
        string date = "15 de Agosto";

        DateTime? parsedDate = _parser.TryParseDateTime(date);
        
        Assert.That(parsedDate, Is.TypeOf<DateTime>());
        Assert.That(parsedDate, Is.Not.Null);
        Assert.That(parsedDate, Is.Not.EqualTo(DateTime.Now));
        Assert.That(parsedDate.Value.Day, Is.EqualTo(15));
        Assert.That(parsedDate.Value.Month, Is.EqualTo(8));
        Assert.That(parsedDate.Value.Year, Is.EqualTo(2025));
    }
}