using DirectoryService.Domain.Positions;


public class Position
{
    PosId Id { get;}

    PosName Name { get; set; }

    string Description { get; set; }

    bool IsActive { get; set; }

    DateTime CreatedAt { get; set; }

    DateTime UpdateAt { get; set; }

    public Position(PosId id, PosName name, string description, bool isactive, DateTime createdat, DateTime updateat) {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isactive;
        CreatedAt = createdat;
        UpdateAt = updateat;
    }
}