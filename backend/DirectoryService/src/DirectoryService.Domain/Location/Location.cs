namespace DirectoryService.Domain.Location;

public class Location
{
    LocId Id { get;}
    string Address { get; }
    private LocName Name { get; set; }

    private string Timezone { get; }

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
          location.Name = NewName;
      }
  }
}
