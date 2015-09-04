using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeTrackerApp.Models
{
    public class TrackedTimeViewModel
    {
        [Required]
        [Display(Name = "Date of the time registration")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Spent hours")]
        public double Hours { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}