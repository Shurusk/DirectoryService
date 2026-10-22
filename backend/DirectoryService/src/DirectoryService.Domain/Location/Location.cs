namespace DirectoryService.Domain.Location;
using DirectoryService.Domain.Archive;

public class Location
{
    LocId Id { get;}
    string Address { get; }
    private LocName Name { get; set; }

    private string Timezone { get; set; }

    private DateTime CreatedAt { get; }
    DateTime UpdateAt { get; set; }

  public Location(LocId id, LocName name, string address, string timezone, DateTime createdat, DateTime updateat)
  {
      Id = id;
      Name = name;
      Address = address;
      Timezone = timezone;
      CreatedAt = createdat;
      UpdateAt = updateat;
    }

  public class RemoveLocalation
  {
      public void RemoveLocalName(Location location, LocName NewName)
        {
            if (!Archive.ArchiveCondition) location.Name = NewName;
            else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(location.Name));
        }
        public void RemoveLocalTimezone(Location location, string NewTimeZone)
        {
          if (!Archive.ArchiveCondition) location.Timezone = NewTimeZone;
            else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(location.Timezone));
        }
  }
}
