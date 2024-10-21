using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
[ApiController]
public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}