using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Archive;
public class Position
{
    PosId Id { get; }

    private PosName Name { get; set; }

    private string Description { get; }

    bool IsActive { get; }

    private DateTime CreatedAt { get; }

    private DateTime UpdateAt { get; set; }

    public Position(PosId id, PosName name, string description, bool isactive, DateTime createdat, DateTime updateat)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isactive;
        CreatedAt = createdat;
        UpdateAt = updateat;
    }


        public void RemovePosName(Position position, PosName NewName)
        {
        if (!Archive.ArchiveCondition)
        {
            position.Name = NewName;
            position.UpdateAt = DateTime.Now;
        }
        else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(position.Name));
        }
}