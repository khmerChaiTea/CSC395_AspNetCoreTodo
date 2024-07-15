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
        // This method requires no parameters and returns a Task<TodoItem[]>
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
