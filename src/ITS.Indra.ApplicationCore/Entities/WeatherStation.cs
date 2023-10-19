using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Indra.ApplicationCore.Entities;

public class WeatherStation
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Code { get; set; }
    public string? StationModel { get; set; }
}
