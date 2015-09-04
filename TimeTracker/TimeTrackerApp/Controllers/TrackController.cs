using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TimeTrackerApp.DataModels;
using TimeTrackerApp.Models;
using Microsoft.AspNet.Identity;

namespace TimeTrackerApp.Controllers
{
    [Authorize]
    public class TrackController : Controller
    {
        private TimesheetsContext _timesheetsStore = new TimesheetsContext();

        // GET: Track
        public ActionResult Time()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Time(TrackedTimeViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var timesheet = Mapper.Map<Timesheet>(model);
                    timesheet.UserId = User.Identity.GetUserId(); 

                    _timesheetsStore.Timesheets.Add(timesheet);
                    _timesheetsStore.SaveChanges();

                    return View("TimeConfirmation");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Could save your time.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        
        public ActionResult Overview()
        {
            var userId = User.Identity.GetUserId();
            var timesheets = _timesheetsStore.Timesheets
                                             .Where(t => t.UserId == userId)
                                             .OrderByDescending(t => t.Date);
            var trackedTimeList = Mapper.Map<IEnumerable<TrackedTimeViewModel>>(timesheets);

            return View(trackedTimeList);
        }
    }
}