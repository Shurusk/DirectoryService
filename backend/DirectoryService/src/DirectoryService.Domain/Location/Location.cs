namespace DirectoryService.Domain.Location;
using DirectoryService.Domain.Archive;

public class Location
{
    LocId Id { get;}
    string Address { get; }
    private LocName Name { get; set; }
    private string Timezone { get; set; }
    private DateTime CreatedAt { get; set; }
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

  public void RemoveLocalName(Location location, LocName NewName)
    {
        if (!Archive.ArchiveCondition)
        {
          location.Name = NewName;
          location.UpdateAt = DateTime.Now;
        }
        else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(location.Name));
    }
    public void RemoveLocalTimezone(Location location, string NewTimeZone)
    {
        if (!Archive.ArchiveCondition) 
      {
          location.Timezone = NewTimeZone;
          location.UpdateAt = DateTime.Now;
      }
        else throw new ArgumentException("Профиль заархивирован. Измененеие запрещено.", nameof(location.Timezone));
    }
}
