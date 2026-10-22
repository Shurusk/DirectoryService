using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Archive;
public class Position
{
    PosId Id { get; }

    private PosName Name { get; set; }

    private string Description { get; }

    bool IsActive { get; }

    private DateTime CreatedAt { get; }

    private DateTime UpdateAt { get; }

    public Position(PosId id, PosName name, string description, bool isactive, DateTime createdat, DateTime updateat)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isactive;
        CreatedAt = createdat;
        UpdateAt = updateat;
    }

    public class RemovePosition
  {
        public void RemovePosName(Position position, PosName NewName)
        {
            if (Archive.ArchiveCondition == false){
                position.Name = NewName;
            }
        }
  }
}