namespace DirectoryService.Domain.Location;

public record LocTimeZone
{
    public string Value { get; }
    const char separation = '/';
    private LocTimeZone(string inputZone)
    {
        Value = inputZone;
    }

    public static LocTimeZone Create(string input, ITimeZonesStorage storge)
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

        LocTimeZone result = new LocTimeZone(zoneTime);
        if (!storge.Exists(result))
        {
            throw new ArgumentException("Неверный формат TimeZone. Ожидается формат 'Материк/Город' с одним символом '/'.");
        }

        return result;
    }
}

public static class Example
{
    public static void FullTimeZoneExample()
    {
        ITimeZonesStorage storage = new FileTimeZoneStorage("./continents.txt", "./cities.txt");
        LocTimeZone zone = LocTimeZone.Create("Russia/Moscow", storage);
        Console.WriteLine(zone.Value);
    }
}

public interface ITimeZonesStorage
{
    bool Exists(LocTimeZone zone);
}


public sealed class FileTimeZoneStorage : ITimeZonesStorage
{
    private readonly record struct Dummy;
    private readonly Dictionary<string, Dummy> _continents;
    private readonly Dictionary<string, Dummy> _citites;

    private readonly string _continentsPath;
    private readonly string _citiesPath;

    public FileTimeZoneStorage(string continentsPath, string citiesPath)
    {
        _continentsPath = continentsPath;
        _citiesPath = citiesPath;
        _continents = [];
        _citites = [];
        AppendContentsToDictionary(_continentsPath, _continents);
        AppendContentsToDictionary(_citiesPath, _citites);
    }

    private static void AppendContentsToDictionary(string path, Dictionary<string, Dummy> dictionary)
    {
        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        using StreamReader reader = new(fs);
        string? line = null;
        while (line != null)
        {
            dictionary.TryAdd(line, new Dummy());
            line = reader.ReadLine();
        }
    }

    public bool Exists(LocTimeZone zone)
    {
        string key = zone.Value;
        string[] parts = key.Split("/");
        return _citites.ContainsKey(parts[0]) &&
         _continents.ContainsKey(parts[1]);
    }
}