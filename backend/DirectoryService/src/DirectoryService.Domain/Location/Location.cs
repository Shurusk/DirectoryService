using DirectoryService.Domain.Location;

namespace DirectoryService.Domain.Location;

public class Location
{
    LocId Id { get;}
    string Address { get; }
    public string TestField { get; private set; }

//    LocName Name { get; private set; }

  //  string Timezone { get; private set; }

    DateTime CreatedAt { get; set; }
    
    // DateTime UpdateAt { get; set; }

//     public Location(LocId id, LocName name, string address, string timezone, DateTime createdat, DateTime updateat) {


//         Id = id;
//         Name = name;
//         Address = address;
//         Timezone = timezone;
//         CreatedAt = createdat;
//         UpdateAt = updateat;
//     }
}
