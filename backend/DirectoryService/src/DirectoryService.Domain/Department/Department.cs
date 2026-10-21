namespace DirectoryService.Domain.Department;

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

  public class RemoveDepartment
  {
    public void RemoveDepName(Department department, DepName NewName)
    {
      if (department.IsActive == true)
      {
        throw new InvalidOperationException("Cannot remove the name of an active department.");
      }
      else
      {
        department.Name = NewName;
      }
      
    }
  }
    public void AddBop()
    { }
    private static int GetLength(string name)
    {
        return name.Length;
    }
}



