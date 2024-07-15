using System.Net;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreTodo.Controllers.Mvc
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            // Get to-do items from database

            // Put items into a model
            var model = new TodoViewModel
            {
                Items = new List<TodoItem>()
            };

            var item = new TodoItem
            {
                DueAt =  new DateTimeOffset(new DateTime(2024, 7, 12)),
                Title = "This is a test item"
            };

            model.Items.Add(item);

            // Render view using the model
            return View(model);

        }
    }
}