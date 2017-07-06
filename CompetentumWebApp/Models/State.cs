using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class State
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Статус")]
        public string StateName { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public State()
        {
            Resumes = new List<Resume>();
        }
    }
}