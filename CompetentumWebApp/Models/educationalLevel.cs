using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class educationalLevel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string Id_name { get; set; }

        [JsonProperty(PropertyName = "education.level.name")]
        [Display(Name = "Уровень образования")]
        public string name { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public educationalLevel()
        {
            Resumes = new List<Resume>();
        }
    }
}