using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestProject.Web.Controllers;

[Authorize]
public class BookController : Controller
{

    public IActionResult Index()
    {
        return View();
    } 
}
