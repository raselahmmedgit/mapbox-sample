using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.MapBoxSample.ViewModels
{
    public class MapboxGeometryViewModel
    {
        public string GeometryType { get; set; }
        //public MapboxGeometryCoordinateViewModel[] GeometryCoordinates { get; set; }
        public decimal GeometryCoordinateX { get; set; }
        public decimal GeometryCoordinateY { get; set; }
    }

    public class MapboxGeometryCoordinateViewModel
    {
        public decimal GeometryCoordinateX { get; set; }
        public decimal GeometryCoordinateY { get; set; }
    }

    public class MapboxPropertyViewModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string UrlLink { get; set; }
        public string MarkerSymbol { get; set; }
        public string CityName { get; set; }
    }
}