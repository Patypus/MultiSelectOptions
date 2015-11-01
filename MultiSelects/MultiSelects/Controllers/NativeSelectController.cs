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
        public ViewResult Display(VisitedLocationsDisplayViewModel model)
        {
            if (model.SelectedLocationIds == null)
            {
                model.SelectedLocationIds = new List<int>();
            }

            var locations = GetAllLocations();
            model.AllLocations = locations;
            model.Message = Strings.SelectLocationsMessage;

            return View(model);
        }
    }
}