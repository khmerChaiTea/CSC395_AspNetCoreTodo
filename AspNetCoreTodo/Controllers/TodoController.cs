using System.Net;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo.Controllers.Mvc;

public class TodoController : Controller
{
    private readonly ITodoItemService _todoItemService;

    // Constructor injection: ITodoItemService is injected into the controller
    public TodoController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }

    // Action method for handling requests to /Todo/Index
    public async Task<IActionResult> Index()
    {
        // Call service to get incomplete to-do items asynchronously
        var items = await _todoItemService.GetIncompleteItemsAsync();
        // Get to-do items from database

        // Put items into a model
        // Prepare view model to pass data to the view
        var model = new TodoViewModel
        {
            Items = items // Initialize list of to-do items
        };

        // Render view using the model, passing the populated view model to the view
        return View(model);

    }
}
