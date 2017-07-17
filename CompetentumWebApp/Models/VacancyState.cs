using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class VacancyState
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Статус")]
        public string VacancyStateName { get; set; }

        public ICollection<Vacancy> Vacancys { get; set; }
        public VacancyState()
        {
            Vacancys = new List<Vacancy>();
        }
    }
}