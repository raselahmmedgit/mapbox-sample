using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.MapBoxSample.ViewModels
{
    public class GeoDataViewModel
    {
        public string type { get; set; }

        public GeoGeometryViewModel geometry { get; set; }
        public GeoPropertyViewModel properties { get; set; }
    }

    public class GeoGeometryViewModel
    {
        public string type { get; set; }
        public decimal[] coordinates { get; set; }
    }

    public class GeoPropertyViewModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        //public string MarkerColor { get; set; }
        //public string MarkerSymbol { get; set; }
    }
}