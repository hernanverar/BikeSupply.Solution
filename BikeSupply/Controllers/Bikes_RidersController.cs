using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BikeSupply.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikeSupply.Controllers
{
  public class Bikes_RidersController : Controller
  {
    private readonly RegistrarTrackerContext _db;

    public Bikes_RidersController(BikeSupplyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Bike_Rider> model = _db.Bikes_Riders.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Bike_Rider bike_rider)
    {
      _db.Bikes_Riders.Add(bike_rider);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }  
}  
