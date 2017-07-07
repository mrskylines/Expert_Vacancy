using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Schedule
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string Id_name { get; set; }
        [Display(Name = "График работы")]
        public string ScheduleName { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public Schedule()
        {
            Resumes = new List<Resume>();
        }
    }
}