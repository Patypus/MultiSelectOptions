using MultiSelects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSelects.Models
{
    public class VisitedLocationsDisplayViewModel
    {
        public List<int> SelectedLocationIds { get; set; }
        public List<Location> AllLocations { get; set; }
        public string Message { get; set; }
    }
}