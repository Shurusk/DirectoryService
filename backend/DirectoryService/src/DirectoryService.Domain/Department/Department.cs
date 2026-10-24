namespace DirectoryService.Domain.Department;
using DirectoryService.Domain.Archive;
public sealed class Department
{
    private readonly List<Department> _department = [];
    DepId Id { get; }
    DepName Name { get; set; }
    string Identifie { get; set; }
    DepId? ParentId { get;}
    string? Path { get; set; }
    short Depth { get; set; }
    bool IsActive { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdateAt { get; set; }

    public Department(DepId id, DepName name, string identifie, DepId? parentid, short depth, bool isactive, DateTime createdat, DateTime updateat)
    {
        Id = id;
        Name = name;
        Identifie = identifie;
        ParentId = parentid;
        Depth = depth;
        IsActive = isactive;
        CreatedAt = createdat;
        UpdateAt = updateat;


    }


    public void RemoveDepName(Department department, DepName NewName)
        {
        if (!Archive.ArchiveCondition) 
            {
            department.Name = NewName;
            department.UpdateAt = DateTime.Now;
        }
            else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(department.Name));
          }

    public void AddBop()
    { }
    private static int GetLength(string name)
    {
        return name.Length;
    }
}



