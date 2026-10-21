namespace DirectoryService.Domain.Location;

public readonly record struct LocId 
{
    public Guid Value {get;}
    public LocId(Guid inputId){

    if (inputId == Guid.Empty)
        {
            throw new ArgumentException("Guid cannot be empty.", nameof(inputId));
        }

        Value = inputId;
    }
    public static implicit operator LocId(Guid value) => new(value);

    public static implicit operator Guid(LocId id) => id.Value;

}