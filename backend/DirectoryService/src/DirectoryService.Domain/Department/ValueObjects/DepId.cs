using static System.Guid;
namespace DirectoryService.Domain.Department;

public readonly record struct DepId 
{
    public Guid Value {get;}
    public DepId(Guid inputId){

    if (inputId == Guid.Empty)
        {
            throw new ArgumentException("Guid cannot be empty.", nameof(inputId));
        }

        Value = inputId;
    }
    public static implicit operator DepId(Guid value) => new(value);

    public static implicit operator Guid(DepId id) => id.Value;

}