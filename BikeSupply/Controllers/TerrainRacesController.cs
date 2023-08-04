using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BikeSupply.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikeSupply.Controllers
{
  public class TerrainRacesController : Controller
  {
    private readonly BikeSupplyContext _db;

    public TerrainRacesController(BikeSupplyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<TerrainRace> model = _db.TerrainRaces.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(TerrainRace terrainrace)
    {
      _db.TerrainRaces.Add(terrainrace);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }  
}  
