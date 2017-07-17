using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetentumWebApp.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string VacancyName { get; set; }

        public int? VacancyStateId { get; set; }//статус
        public VacancyState VacancyState { get; set; }

        [Display(Name = "Дата создания")]
        public string VacancyCreationDate { get; set; }
        [Display(Name = "Инициатор")]
        public string VacancyInitiator { get; set; }
        [Display(Name = "Регион")]
        public string VacancyRegion { get; set; }
        [Display(Name = "Направление работы (группировка)")]
        public string VacancyGroup { get; set; }

        //определение навигационных свойств
        public virtual ICollection<Resume> Resumes { get; set; }
        public Vacancy()
        {
            Resumes = new List<Resume>();//инициализируем коллекцию пустым списком
        }
    }
}