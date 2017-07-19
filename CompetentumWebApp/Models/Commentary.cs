using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Commentary
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Комментарий")]
        public string CommentaryText { get; set; }

        [Display(Name = "Дата комментария")]
        public DateTime CommentaryDate { get; set; }

        public ICollection<Resume> Resumes { get; set; }
        public Commentary()
        {
            Resumes = new List<Resume>();
        }
    }
}