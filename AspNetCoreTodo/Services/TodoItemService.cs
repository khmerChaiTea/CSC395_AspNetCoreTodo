using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.EntityFrameworkCore;

public class TodoItemService : ITodoItemService
{
    private readonly ApplicationDbContext _context;

    public TodoItemService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TodoItem[]> GetIncompleteItemsAsync()
    {
        return await _context.Items
            .Where(x => x.IsDone == false)
            .ToArrayAsync();
    }
}