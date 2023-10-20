using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Indra.ApplicationCore.Entities
{
    public class WeatherStation
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!; //!il default per una stringa essendo nullabile è string.empty
        public double? Latitude { get; set; }
        public double? Longitudine { get; set; }
        public string? Code { get; set; }
        public string? StationModel { get; set; }

        //dentro infrastucture sono le cos

    }
}
