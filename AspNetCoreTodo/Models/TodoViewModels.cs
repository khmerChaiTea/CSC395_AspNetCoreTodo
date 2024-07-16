namespace AspNetCoreTodo.Models;

public class TodoViewModel
{
    // view model should be a separate class that holds an array
    public TodoItem[] Items { get; set; }
}
