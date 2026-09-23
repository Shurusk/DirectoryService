public class Location
{
    Guid Id { get; set; }
    string Address { get; set; }

    string Name { get; set; }

    string Timezone { get; set; }

    DateTime CreatedAt { get; set; }
    
    DateTime UpdateAt { get; set; }

    public Location(Guid id, string name) {

        if (id == Guid.Empty)
        {
            throw new ArgumentException("Индификатор не может быть пустым.", nameof(id));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Название должности не может быть пустым", nameof(name));
        }

        Id = id;
        Name = name;
    }
}
