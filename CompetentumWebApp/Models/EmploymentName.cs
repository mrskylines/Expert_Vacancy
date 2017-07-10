using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class EmploymentName
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string Id_name { get; set; }
        [Display(Name = "Название занятости")]
        public string Employement_Name { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public EmploymentName()
        {
            Resumes = new List<Resume>();
        }
    }
}