using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeTrackerApp.DataModels;
using TimeTrackerApp.Models;

namespace TimeTrackerApp
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<TrackedTimeViewModel, Timesheet>();
                cfg.CreateMap<Timesheet, TrackedTimeViewModel>();
            });
        }
    }
}