using static System.Guid;
namespace DirectoryService.Domain.Positions;

public readonly record struct PosId 
{
    public Guid Value {get;}
    public PosId(Guid inputId){

    if (inputId == Guid.Empty)
        {
            throw new ArgumentException("Guid cannot be empty.", nameof(inputId));
        }

        Value = inputId;
    }
    public static implicit operator PosId(Guid value) => new(value);

    public static implicit operator Guid(PosId id) => id.Value;

}