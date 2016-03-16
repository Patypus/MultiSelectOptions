using MultiSelects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiSelects.Controllers
{
    public class BootstrapSelectController : Controller
    {
        public ViewResult Display(VisitedLocationsDisplayViewModel model)
        {
            return View(model);
        }
    }
}