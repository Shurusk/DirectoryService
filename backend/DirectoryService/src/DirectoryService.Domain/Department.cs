using System.ComponentModel.DataAnnotations;

namespace DirectoryService.Domain;

public class Department
{
    Guid Id { get; set; }

    string Name { get; set; }

    string Identifie { get; set; }

    Guid ParentId { get; set; }
    string Path { get; set; }

    short Depth { get; set; }

    bool IsActive { get; set; }

    DateTime CreatedAt { get; set; }

    DateTime UpdateAt { get; set; }

    public Department(Guid id, string name, string identifie, Guid parentid, short depth, bool isactive, DateTime createdat, DateTime updateat)
    {


        if (id == Guid.Empty)
        {
            throw new ArgumentException("Индификатор не может быть пустым.", nameof(id));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Название должности не может быть пустым.", nameof(name));
        }

        if (name.Length > 256)
        {
            throw new ArgumentException("Название должности слишком большое.", nameof(name));
        }

        Id = id;
        Name = name;
        Identifie = identifie;
        ParentId = parentid;
        Depth = depth;
        IsActive = isactive;
        CreatedAt = createdat;
        UpdateAt = updateat;


    }

    private static int GetLength(string name)
    {
        return name.Length;
    }
}



