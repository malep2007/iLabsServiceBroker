using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iLabsServiceBroker.Controllers
{
    public class ExperimentController : Controller
    {
        // GET: Experiment
        public ActionResult Index()
        {
            ViewBag.Title = "Your Experiments";

            var experimentDetails = new iLabsServiceBroker.Models.ExperimentViewModel
            {
                ExperimentName = "Halfwave Rectification Lab",
                ExperimentGroup = "First Year CMP Eng Class",
                DateCreated = DateTime.Now,
                ExperimentAttempts = 10,
                CourseCategory = "Circuit Theory",
            };
            return View(experimentDetails);
        }
    }
}