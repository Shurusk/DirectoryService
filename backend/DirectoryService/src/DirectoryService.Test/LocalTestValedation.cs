namespace DirectoryService.Test;

public class LocalTestValedation
{
    public static void CheckTimeZone(string input)
    {
        string zoneTime = input?.Trim() ?? string.Empty;
        string[] parts = zoneTime.Split(separation, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2)
        {
            throw new ArgumentException("Неверный формат TimeZone. Ожидается формат 'Материк/Город' с одним символом '/'.");
        }

        string continent = parts[0];
        if (continent.Select(x => x).Count(c => c == ' ') > 0)
        {
            throw new ArgumentException("Неверный формат TimeZone. Ожидается формат 'Материк/Город' с одним символом '/'.");
        }

        string city = parts[1];
        if (city.Select(x => x).Count(c => c == ' ') > 0)
        {
            throw new ArgumentException("Неверный формат TimeZone. Ожидается формат 'Материк/Город' с одним символом '/'.");
        }
    }

    const char separation = '/';

    [Fact]
    public void Success_Valedation()
    {
        string inputZone = "Asia/Krasnoyarsk";
        CheckTimeZone(inputZone);
    }

    [Theory]
    [InlineData("Test")]
    [InlineData("No Time Zone")]
    [InlineData("   ")]
    [InlineData("")]
    [InlineData("North America/Delaware")]
    public void Test_FailureValidation(string value)
    {
        Assert.ThrowsAny<Exception>(() =>
        {
            CheckTimeZone(value);
        });
    }
}
