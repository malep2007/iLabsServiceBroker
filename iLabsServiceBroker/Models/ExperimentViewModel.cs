using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace iLabsServiceBroker.Models
{
    public class ExperimentViewModel
    {
        public string ExperimentName { get; set; }
        public string ExperimentGroup { get; set; }
        public DateTime DateCreated { get; set; }
        public string CourseCategory { get; set; }

        public int ExperimentAttempts { get; set; }
    }
}