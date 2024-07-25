using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models;

public class TodoItem
{
    // Add userId
    public string? UserId { get; set; }

    // Globally unique identifier
    public Guid Id { get; set; }

    // Boolean (true/false value)
    public bool IsDone { get; set; }

    // String (text value)
    [Required]
    public string? Title { get; set; }

    [Required]
    public DateTimeOffset? DueAt { get; set; } = DateTimeOffset.Now.AddDays(3);
}
