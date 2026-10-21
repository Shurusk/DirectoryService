using System;
namespace DirectoryService.Domain.Positions;

public readonly record struct PosName 
{
    public string Value { get; }
    public const int MAX_LENGHT = 256;
    public const int MIN_LENGHT = 5;
    public PosName(string inputName){
        string name = inputName?.Trim() ?? string.Empty;

        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));

        if (name.Length > MAX_LENGHT || name.Length < MIN_LENGHT)
        {
            throw new ArgumentException("Название имеет не верную длинну. допустимы значения от 5 до 256.", nameof(name));
        }
        Value = name;
    }
    public static implicit operator PosName(string value) => new(value);

    public static implicit operator string(PosName name) => name.Value;

}