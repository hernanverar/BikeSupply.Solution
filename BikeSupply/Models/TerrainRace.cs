using System.Collections.Generic;

namespace BikeSupply.Models
{
  public class TerrainRace
  {
    public int TerrainRaceId { get; set; }
    public string TerrainRaceName { get; set; }
    public List<Bike> Bikes { get; set; }
    public List<Rider> Riders { get; set; }
  }
}