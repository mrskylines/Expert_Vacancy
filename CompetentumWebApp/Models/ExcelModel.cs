using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetentumWebApp.Models
{
    public class ExcelModel
    {
        public int ID
        {
            get;
            set;
        }

        [Display(Name = "Название")]
        public string VacName
        {
            get;
            set;
        }

        [Display(Name = "Статус")]
        public string VacState
        {
            get;
            set;
        }

        [Display(Name = "Дата создания")]
        public string VacCreationDate
        {
            get;
            set;
        }

        [Display(Name = "Инициатор")]
        public string VacInititator
        {
            get;
            set;
        }

        [Display(Name = "Регион")]
        public string VacRegion
        {
            get;
            set;
        }

        [Display(Name = "Направление работы (группировка)")]
        public string VacGroup
        {
            get;
            set;
        }
    }
}