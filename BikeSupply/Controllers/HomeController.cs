using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BikeSupply.Models;

namespace BikeSupply.Controllers
{
    public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}
}
