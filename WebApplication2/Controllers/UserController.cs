using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}