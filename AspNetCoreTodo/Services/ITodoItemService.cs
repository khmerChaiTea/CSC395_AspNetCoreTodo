// Did not see a Services directory so I created one and this C# file
// Without the using statement, you'll see an error
using System;
using System.Collections.Generic;
using System. Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
        
        Task<bool> AddItemAsync(TodoItem newItem);
        
        Task<bool> MarkDoneAsync(Guid id);
    }
}
