namespace DirectoryService.Domain;

public class Department
{
    Guid Id { get; set; }

    string Name { get; set; }

    string Identifie { get; set; }

    Guid ParentId { get; set; }
    string Path { get; set; }

    short Depth { get; set; }

    bool IsActive { get; set; }

    DateTime CreatedAt { get; set; }

    DateTime UpdateAt { get; set; }

    public Department(Guid id, string name)
    {

        
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

        string Path = Name.ToLower() switch
{
    "закупки" => "",
    "рабочий"  => "",
    "продажник"   => "",
    _         => "Несуществующее значение." 
};
    }
}



