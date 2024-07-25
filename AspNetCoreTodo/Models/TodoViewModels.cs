namespace AspNetCoreTodo.Models;

public class TodoViewModel
{   
    // Help Items stop complaining about null
    public TodoViewModel()
    {
        Items = Array.Empty<TodoItem>();
    }

    // view model should be a separate class that holds an array
    public TodoItem[] Items { get; set; }
}
