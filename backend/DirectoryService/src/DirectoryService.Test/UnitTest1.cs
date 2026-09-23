using DirectoryService.Domain;
namespace DirectoryService.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Guid Id = Guid.NewGuid();
        Department Name = new Department(Id, "Закупки");
        Location Address = new Location(Id, "Менеджер по закупкам");

    }
}
