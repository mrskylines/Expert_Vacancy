using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class language
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string list_id { get; set; }

        [JsonProperty(PropertyName = "language[].name")]
        [Display(Name = "Язык")]
        public string list_name { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public language()
        {
            Resumes = new List<Resume>();
        }
    }
}