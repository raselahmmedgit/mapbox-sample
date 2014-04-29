using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.MapBoxSample.ViewModels;

namespace RnD.MapBoxSample.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }

        public ActionResult CustomMarkerTooltip()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CustomMarkerTooltipData()
        {
            try
            {

                var mapboxGeometryViewModelList = new List<MapboxGeometryViewModel>()
                {
                    new MapboxGeometryViewModel()
                    {
                        GeometryType = "Point",
                        GeometryCoordinateX = Convert.ToDecimal(-77.03),
                        GeometryCoordinateY = Convert.ToDecimal(38.90)
                    },
                    new MapboxGeometryViewModel()
                    {
                        GeometryType = "Point",
                        GeometryCoordinateX = Convert.ToDecimal(-87.63),
                        GeometryCoordinateY = Convert.ToDecimal(41.88)
                    },
                    new MapboxGeometryViewModel()
                    {
                        GeometryType = "Point",
                        GeometryCoordinateX = Convert.ToDecimal(-74.00),
                        GeometryCoordinateY = Convert.ToDecimal(40.71)
                    }
                };

                var mapboxPropertyViewModelList = new List<MapboxPropertyViewModel>()
                {
                    new MapboxPropertyViewModel()
                    {
                        Id = 1,
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Cherry_Blossoms_and_Washington_Monument.jpg/320px-Cherry_Blossoms_and_Washington_Monument.jpg",
                        UrlLink = "https://en.wikipedia.org/wiki/Washington,_D.C.",
                        MarkerSymbol = "star",
                        CityName = "Washington, D.C."
                    },
                    new MapboxPropertyViewModel()
                    {
                        Id = 1,
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Chicago_sunrise_1.jpg/640px-Chicago_sunrise_1.jpg",
                        UrlLink = "https://en.wikipedia.org/wiki/Chicago",
                        CityName = "Chicago"
                    },
                    new MapboxPropertyViewModel()
                    {
                        Id = 1,
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/NYC_Top_of_the_Rock_Pano.jpg/640px-NYC_Top_of_the_Rock_Pano.jpg",
                        UrlLink = "https://en.wikipedia.org/wiki/New_York_City",
                        CityName = "New York City"
                    }
                };



                var customMarkerTooltipViewModel = new CustomMarkerTooltipViewModel
                {
                    Id = 1,
                    Name = "Bappi",
                    type = "Feature",
                    MapboxGeometryViewModelList = mapboxGeometryViewModelList.ToArray(),
                    MapboxPropertyViewModelList = mapboxPropertyViewModelList.ToArray(),
                };

                return Json(new { data = customMarkerTooltipViewModel }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { data = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }

        //LoadGeoJSON
        public ActionResult LoadGeoJSON()
        {
            return View();
        }

        //Final
        public ActionResult Final()
        {
            return View();
        }

        //FinalCustom
        public ActionResult FinalCustom()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoadGeoJSONData()
        {
            try
            {

                var geoGeometryViewModel1 = new GeoGeometryViewModel()
                    {
                        type = "Point",
                        coordinates = new decimal[] { Convert.ToDecimal(-77.03238901390978), Convert.ToDecimal(38.913188059745586) }
                    };

                var geoGeometryViewModel2 = new GeoGeometryViewModel()
                    {
                        type = "Point",
                        coordinates = new decimal[] { Convert.ToDecimal(-122.414), Convert.ToDecimal(37.776) }
                    };

                var geoPropertyViewModel1 = new GeoPropertyViewModel()
                    {
                        title = "Mapbox DC",
                        description = "1714 14th St NW, Washington DC",
                        url = "https://en.wikipedia.org/wiki/Washington,_D.C."
                    };

                var geoPropertyViewModel2 = new GeoPropertyViewModel()
                    {
                        title = "Mapbox SF",
                        description = "155 9th St, San Francisco",
                        url = "https://en.wikipedia.org/wiki/Washington,_D.C."
                    };

                var geoDataViewModelList = new List<GeoDataViewModel>
                {
                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = geoGeometryViewModel1,
                        properties = geoPropertyViewModel1
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = geoGeometryViewModel2,
                        properties = geoPropertyViewModel2
                    },
                    
                };

                return Json(geoDataViewModelList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString(), JsonRequestBehavior.AllowGet);
            }
        }

    }
}
