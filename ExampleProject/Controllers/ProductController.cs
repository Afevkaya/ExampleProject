using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Controllers;

public class ProductController : Controller
{
    public IActionResult GetProducts()
    {
        return View();
    }
}
