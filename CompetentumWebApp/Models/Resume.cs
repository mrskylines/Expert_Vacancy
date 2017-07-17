using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetentumWebApp.Models
{
    public class Resume
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ExternalId { get; set; }

        public int? SourceId { get; set; }//источник
        public Source Source { get; set; }

        public int? StateId { get; set; }//статус
        public State State { get; set; }

        [Display(Name = "Дата смены статуса")]
        public string StateDate { get; set; }
        [Display(Name = "Дата собеседования")]
        public string InterviewDate { get; set; }

        [Display(Name = "Комментарий")]
        public string Commentary { get; set; }

        [JsonProperty(PropertyName = "id")]
        [HiddenInput(DisplayValue = false)]
        public string ResumeId { get; set; }//Идентификатор резюме

        [JsonProperty(PropertyName = "last_name")]
        [Display(Name = "Фамилия")]
        public string last_name { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        [Display(Name = "Имя")]
        public string first_name { get; set; }

        [JsonProperty(PropertyName = "middle_name")]
        [Display(Name = "Отчество")]
        public string middle_name { get; set; }

        public int? GenderUserId { get; set; }
        public Gender Gender { get; set; }//Название пола gender.name

        [JsonProperty(PropertyName = "birth_date")]
        [Display(Name = "Дата рождения")]
        public string birth_date { get; set; }

        [JsonProperty(PropertyName = "area.name")]
        [Display(Name = "Город")]
        public string CityName { get; set; }//Название города area.name

        [JsonProperty(PropertyName = "metro.name")]
        [Display(Name = "Метро")]
        public string MetroName { get; set; }//Название станции metro.name
         
        [Display(Name = "Email/телефон/skype")]
        public string PhoneNumber { get; set; }//Отформатированный номер телефона (при указании телефона) 
                                               //contact[].value.formatted

        [JsonProperty(PropertyName = "title")]
        [Display(Name = "Должность")]
        public string SpecializationName { get; set; }//Название специализации specialization[].name
        //    public string profarea_id { get; set; }

        [Display(Name = "Область деятельности")]
        public string profarea_name { get; set; }//Название профессиональной области, в которую входит специализация
                                                 //specialization[].profarea_name

        [JsonProperty(PropertyName = "salary.amount")]
        [Display(Name = "Желаемая зарплата")]
        public Double SalaryAmount { get; set; }//Желаемая зарплата salary.amount

        public int? CurrencyId { get; set; }
        public Currency Currency { get; set; }//Идентификатор валюты salary.currency

        public int? EmploymentNameId { get; set; }//название типа занятости
        public EmploymentName EmploymentName { get; set; }

        public int? ScheduleId { get; set; }//название графика работы
        public Schedule Schedule { get; set; }
        
        public int? educationalLevelId { get; set; }//Название уровня образования education.level.name
        public educationalLevel educationalLevel { get; set; }

        public int? languageId { get; set; }//Название уровня образования education.level.name
        public language language { get; set; }

        public int? languageLevelId { get; set; }//Название уровня образования education.level.name
        public languageLevel languageLevel { get; set; }

        //Опыт работы
        [Display(Name = "Название компании old")]
        public string ExperienceCompany { get; set; }//Организация experience[].company
        
        [Display(Name = "Должность old")]
        public string ExperiencePosition { get; set; }//Должность experience[].position
       
        //таблица опытов работы
        public virtual ICollection<ExperienceJob> ExperienceJobs { get; set; }

        //таблица вакансий
        public virtual ICollection<Vacancy> Vacancies { get; set; }
        public Resume()
        {
            ExperienceJobs = new List<ExperienceJob>();
            Vacancies = new List<Vacancy>();
        }

        [JsonProperty(PropertyName = "skills")]
        [Display(Name = "Дополнительная информация")]
        public string skills { get; set; }//Дополнительная информация, описание навыков в свободной форме skills =string/null
    }

}