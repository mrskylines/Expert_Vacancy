using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class languageLevel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string Id_name { get; set; }

        [JsonProperty(PropertyName = "language[].level.name")]
        [Display(Name = "Уровень знаний языка")]
        public string Level_name { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public languageLevel()
        {
            Resumes = new List<Resume>();
        }
    }
}