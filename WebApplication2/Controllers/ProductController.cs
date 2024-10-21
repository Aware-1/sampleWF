using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}