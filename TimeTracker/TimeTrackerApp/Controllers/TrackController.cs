using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTrackerApp.DataModels;
using TimeTrackerApp.Models;

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
            var timesheets = _timesheetsStore.Timesheets.OrderByDescending(t => t.Id);
            var trackedTimeList = Mapper.Map<IEnumerable<TrackedTimeViewModel>>(timesheets);

            return View(trackedTimeList);
        }
    }
}