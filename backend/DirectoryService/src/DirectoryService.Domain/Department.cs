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

    public DepartmentName(Guid id, string name)
    {

        Id = id;

        Name = name;
    }
}



