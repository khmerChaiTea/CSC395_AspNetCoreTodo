using System.Net;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreTodo.Controllers.Mvc;

public class TodoController : Controller
{
    public IActionResult Index()
    {
        // Get to-do items from database
        // Put items into a model

        var model = new TodoViewModel();

        var item = new TodoItem();
        item.DueAt = new DateTimeOffset(new DateTime(2024, 7, 10));
        item.Title = "This is a test item";

        model.Items = new TodoItem[1];
        model.Items[0] = item;

        // Render view using the model
        return View(model);
    }
}
