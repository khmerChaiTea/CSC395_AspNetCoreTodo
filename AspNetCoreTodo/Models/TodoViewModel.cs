namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        // Help Items stop complaining about null
        public TodoViewModel()
        {
            Items = Array.Empty<TodoItem>();
        }

        public TodoItem[] Items { get; set; }

        // Add this if you want to bind to the form for adding new items
        public TodoItem? NewItem { get; set; }
    }
}