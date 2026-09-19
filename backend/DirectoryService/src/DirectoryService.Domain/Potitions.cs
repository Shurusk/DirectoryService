public class Position
{
    Guid Id { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    bool IsActive { get; set; }

    DateTime CreatedAt { get; set; }
    
    DateTime UpdateAt { get; set; }
}