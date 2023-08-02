using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BikeSupply.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikeSupply.Controllers
{
  public class BikeController : Controller
  {
    [HttpPost]
    public ActionResult Create(Bike bike)
    {
      return RedirectToAction("Index");
    }
  } 
}  