using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        // Globally unique identifier
        public Guid Id { get; set; }

        // Boolean (true/false value)
        public bool IsDone { get; set; }

        // String (text value)
        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}