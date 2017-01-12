using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iLabsServiceBroker.Controllers
{
    public class MyExperimentController : Controller
    {
        // GET: MyExperiment
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return Redirect("Account/Login");
            }
        }
    }
}