using System;
namespace Common;

public static class What
{
    public static string Name(string inputName){
        string name = inputName.Trim() ?? string.Empty;

        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));

        if (name.Length > 256 || name.Length < 5)
        {
            throw new ArgumentException("Название имеет не верную длинну. допустимы значения от 5 до 256.", nameof(name));
        }
        return name;
    }
    

}