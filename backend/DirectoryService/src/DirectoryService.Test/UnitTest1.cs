using DirectoryService.Domain;
namespace DirectoryService.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Department Name = new DepartmentName(Guid.NewGuid(), "Покупки");
        Location Address = new Location(Guid.NewGuid(), "Нижние челны");

    }
}
