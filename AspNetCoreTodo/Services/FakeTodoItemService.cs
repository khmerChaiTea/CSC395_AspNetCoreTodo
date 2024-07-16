using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    // Implementation of ITodoItemService interface using fake data
    public class FakeTodoItemService:ITodoItemService
    {
        // Method to retrieve incomplete to-do items asynchronously
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            // Create a fake to-do item 1
            var item1 = new TodoItem
            {
                Title = "Learn Asp.NET Core", // Title of the first to-do item
                DueAt = DateTimeOffset.Now.AddDays(1) // Due date of the first to-do item (1 day from now)
            };

            // Create a fake to-do item 2
            var item2 = new TodoItem
            {
                Title = "Build awesome apps", // Title of the second to-do item
                DueAt = DateTimeOffset.Now.AddDays(2) // Due date of the second to-do item (2 days from now)
            };

            // Return a completed task with an array containing the fake to-do items
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}