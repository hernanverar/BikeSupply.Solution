using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BikeSupply.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikeSupply.Controllers
{
  public class RidersController : Controller
  {
    private  readonly BikeSupplyContext _db;
    public RidersController(BikeSupplyContext db)
    {
      _db = db;
    }
    [HttpPost]
    public ActionResult Create(Rider rider)
    {
      return RedirectToAction("Index");
    }
  } 
}