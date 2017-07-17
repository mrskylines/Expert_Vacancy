using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Currency
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "salary.currency")]
        [Display(Name = "Название валюты")]
        public string CurrencyName { get; set; }

        [Display(Name = "Аббревиатура валюты")]
        public string CurrencyAbbr { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public Currency()
        {
            Resumes = new List<Resume>();
        }
    }
}