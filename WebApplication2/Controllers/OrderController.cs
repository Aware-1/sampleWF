using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
[ApiController]
public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}