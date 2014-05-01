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
                        UrlLink = "http://raselahmmed.com",
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
                        url = "http://raselahmmed.com"
                    };

                var geoPropertyViewModel2 = new GeoPropertyViewModel()
                    {
                        title = "Mapbox SF",
                        description = "155 9th St, San Francisco",
                        url = "http://raselahmmed.com"
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

        [HttpGet]
        public ActionResult FinalData()
        {
            try
            {

                #region Dhaka

                //GPSLongitude, GPSLatitude
                var DhakaGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(90.40722222), Convert.ToDecimal(23.71027778) }
                };

                var DhakaProperty = new GeoPropertyViewModel()
                {
                    title = "Dhaka",
                    description = "<p><strong>Dhaka</strong>, <span>Bangladesh</span></p>",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Chittagong

                var ChittagongGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(91.83638889), Convert.ToDecimal(22.33305556) }
                };

                var ChittagongProperty = new GeoPropertyViewModel()
                {
                    title = "Chittagong",
                    description = "Chittagong, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Sylhet

                var SylhetGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(91.87166667), Convert.ToDecimal(24.89666667) }
                };

                var SylhetProperty = new GeoPropertyViewModel()
                {
                    title = "Sylhet",
                    description = "Sylhet, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Rajshahi

                var RajshahiGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(88.6), Convert.ToDecimal(24.36666667) }
                };

                var RajshahiProperty = new GeoPropertyViewModel()
                {
                    title = "Rajshahi",
                    description = "Rajshahi, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Khulna

                var KhulnaGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(89.56722222), Convert.ToDecimal(22.81333333) }
                };

                var KhulnaProperty = new GeoPropertyViewModel()
                {
                    title = "Khulna",
                    description = "Khulna, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Barisal

                var BarisalGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(90.37111111), Convert.ToDecimal(22.70194444) }
                };

                var BarisalProperty = new GeoPropertyViewModel()
                {
                    title = "Barisal",
                    description = "Barisal, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                #region Rangpur

                var RangpurGeometry = new GeoGeometryViewModel()
                {
                    type = "Point",
                    coordinates = new decimal[] { Convert.ToDecimal(89.25), Convert.ToDecimal(25.75) }
                };

                var RangpurProperty = new GeoPropertyViewModel()
                {
                    title = "Rangpur",
                    description = "Rangpur, Bangladesh",
                    url = "http://raselahmmed.com"
                };

                #endregion

                var geoDataViewModelList = new List<GeoDataViewModel>
                {
                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = DhakaGeometry,
                        properties = DhakaProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = ChittagongGeometry,
                        properties = ChittagongProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = SylhetGeometry,
                        properties = SylhetProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = RajshahiGeometry,
                        properties = RajshahiProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = KhulnaGeometry,
                        properties = KhulnaProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = BarisalGeometry,
                        properties = BarisalProperty
                    },

                    new GeoDataViewModel()
                    {
                        type = "Feature", 
                        geometry = RangpurGeometry,
                        properties = RangpurProperty
                    }
                    
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
