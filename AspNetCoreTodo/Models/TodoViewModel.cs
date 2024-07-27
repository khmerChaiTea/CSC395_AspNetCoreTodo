namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public TodoItem[]? Items { get; set; }

        // Add this if you want to bind to the form for adding new items
        public TodoItem NewItem { get; set; }
    }
}