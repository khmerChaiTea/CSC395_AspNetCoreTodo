using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class TodoItemService : ITodoItemService
{
    private readonly ApplicationDbContext _context;

    public TodoItemService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddItemAsync(TodoItem newItem)
    {
        newItem.Id = Guid.NewGuid();
        newItem.IsDone = false;
        newItem.DueAt = DateTimeOffset.Now.AddDays(7);

        _context.Items.Add(newItem);
        
        var saveResult = await _context.SaveChangesAsync();
        return saveResult == 1;
    }

    public async Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser CurrentUser)
    {
        return await _context.Items
            .Where(x => x.IsDone == false && x.UserId == CurrentUser.Id)
            .ToArrayAsync();
    }

    public async Task<bool> MarkDoneAsync(Guid id)
    {
        var item = await _context.Items
            .Where(x => x.Id == id)
            .SingleOrDefaultAsync();

        if (item == null) return false;

        item.IsDone = true;

        var saveResult = await _context.SaveChangesAsync();
        return saveResult == 1; // One entity should have been updated
    }
}