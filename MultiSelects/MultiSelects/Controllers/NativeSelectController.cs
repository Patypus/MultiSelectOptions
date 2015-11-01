using MultiSelects.Localaisation;
using MultiSelects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MultiSelects.DataLayer.ServerFacade;

namespace MultiSelects.Controllers
{
    public class NativeSelectController : Controller
    {
        public ViewResult Display(VisitedLocationsDisplayViewModel m)
        {
            var locations = GetAllLocations();
            var model = new VisitedLocationsDisplayViewModel
            {
                AllLocations = locations,
                SelectedLocationIds = new List<int>(),
                Message = Strings.SelectLocationsMessage
            };
            return View(model);
        }
    }
}