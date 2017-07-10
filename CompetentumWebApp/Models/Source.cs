using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Source
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Источник")]
        public string SourceName { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public Source()
        {
            Resumes = new List<Resume>();
        }
    }
}