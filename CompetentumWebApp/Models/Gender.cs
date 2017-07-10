﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Gender
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Пол")]
        public string GenderName { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public Gender()
        {
            Resumes = new List<Resume>();
        }
    }
}