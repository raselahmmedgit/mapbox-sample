using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.MapBoxSample.ViewModels
{
    public class CustomMarkerTooltipViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }

        public MapboxGeometryViewModel[] MapboxGeometryViewModelList { get; set; }
        public MapboxPropertyViewModel[] MapboxPropertyViewModelList { get; set; }
    }

}