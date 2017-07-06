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
        [Display(Name = "Источник")]
        public string Source { get; set; }//источник
        
        [Display(Name = "Дата смены статуса")]
        public string StateDate { get; set; }
        [Display(Name = "Дата собеседования")]
        public string InterviewDate { get; set; }

        //public class User
        //{
        [HiddenInput(DisplayValue = false)]
        public string ResumeId { get; set; }//Идентификатор резюме
        [Display(Name = "Фамилия")]
        public string last_name { get; set; }
        [Display(Name = "Имя")]
        public string first_name { get; set; }
        [Display(Name = "Отчество")]
        public string middle_name { get; set; }
        [Display(Name = "Возраст")]
        public int age { get; set; }
        [Display(Name = "Дата рождения")]
        public string birth_date { get; set; }
        //}

        //public class Gender
        //{
        //    public string id { get; set; }
        //    public string name { get; set; }
        //}

        //public class Area
        //{
        //public string url { get; set; }//Url получения информации о городе
        //public string id { get; set; }//Идентификатор города
        [Display(Name = "Город")]
        public string CityName { get; set; }//Название города area.name
                                            //}

        //public class Metro
        //{
        //public double lat { get; set; }//широта
        //public double lng { get; set; }//долгота располодения станции метро
        //public int order { get; set; }//порядковый номер станцци на метро
        //public string id { get; set; }//Идентификатор станции
        [Display(Name = "Метро")]
        public string MetroName { get; set; }//Название станции metro.name
                                             //}

        //public class RelocationType
        //{
        //public string RelocationId { get; set; }//Идентификатор типа готовности к переезду relocation.type.id
        [Display(Name = "Готов к переезду")]
        public string RelocationName { get; set; }//Название типа готовности к переезду relocation.type.name
                                                  //}

        //public class Area2
        //{
        //    public string url { get; set; }
        //    public string id { get; set; }
        //    public string name { get; set; }
        //}

        //public class Relocation
        //{
        //    public Type type { get; set; }
        //    public List<Area2> area { get; set; }
        //}

        //public class BusinessTripReadiness
        //{
        //public string ReadinessId { get; set; }//Идентификатор типа готовности к командировкам business_trip_readiness.id
        [Display(Name = "Готов к командировкам")]
        public string IsTripReadyName { get; set; }//Название типа готовности к командировкам business_trip_readiness.name
                                                   //}

        //public class Type2
        //{
        //    public string Type2id { get; set; }//Идентификатор типа контакта contact[].type.id
        //    public string Type2name { get; set; }//Название типа контакта contact[].type.name
        //}

        //public class Contact
        //{
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }//Отформатированный номер телефона (при указании телефона) 
                                               //contact[].value.formatted

        //public object comment { get; set; }
        //public Type2 type { get; set; }
        //public bool preferred { get; set; }
        //public object value { get; set; }
        //}

        //public class Type3
        //{
        //    public string Type3id { get; set; }
        //    public string Type3name { get; set; }
        //}

        //public class Site
        //{
        //    //public string url { get; set; }
        //    //public Type3 type { get; set; }
        //}

        //public class Photo//Фотография пользователя, тип object или null
        //{
        //    public string small { get; set; }//Url уменьшенного изображения photo.small
        //    public string medium { get; set; }//Url среднего по размеру изображения photo.medium
        //    public string id { get; set; }//Уникальный идентификатор изображения photo.id
        //}

        //public class Portfolio
        //{
        //    public string small { get; set; }
        //    public string medium { get; set; }
        //    public string id { get; set; }
        //    public string description { get; set; }
        //}

        //public class Specialization
        //{
        //    public string id { get; set; }
        [Display(Name = "Специальность")]
        public string SpecializationName { get; set; }//Название специализации specialization[].name
        //    public string profarea_id { get; set; }

        [Display(Name = "Область деятельности")]
        public string profarea_name { get; set; }//Название профессиональной области, в которую входит специализация
                                                 //specialization[].profarea_name

        //    public bool laboring { get; set; }
        //}

        //public class Salary
        //{
        [Display(Name = "Желаемая зарплата")]
        public int SalaryAmount { get; set; }//Желаемая зарплата salary.amount

        public int? CurrencyId { get; set; }
        public Currency Currency { get; set; }//Идентификатор валюты salary.currency
        
        //}

        //public class Employment
        //{
        //    public string id { get; set; }
        [Display(Name = "Подходящий тип занятости")]
        public string EmploymentName { get; set; }//Название типа занятости employments[].name
        //}

        //public class Schedule
        //{
        //    public string id { get; set; }
        [Display(Name = "График работы")]
        public string ScheduleName { get; set; }//Название графика работы schedules[].name
        //}

        //public class Elementary
        //{
        //[Display(Name = "Учебное заведение")]
        [HiddenInput(DisplayValue = false)]
        public string ElementaryName { get; set; }//Название учебного заведения education.elementary[].name
        //[Display(Name = "Год Выпуска")]
        [HiddenInput(DisplayValue = false)]
        public int ElementaryYear { get; set; }//Год окончания education.elementary[].year
        //}

        //public class Additional
        //{
        //public string AdditionalName { get; set; }//Название курса повышения квалификации education.additional[].name
        //public string AdditionalOrganization { get; set; }//Организация, проводившая курс education.additional[].organization
        //public string AdditionalResult { get; set; }//Специальность / специализация education.additional[].result
        //public int AdditionalYear { get; set; }//Год окончания education.additional[].year
        //}

        //public class Attestation
        //{
        //    public string AttestationName { get; set; }//Название теста или экзамена - аттестации education.attestation[].name
        //    public string AttestationOrganization { get; set; }//Организация, проводившая тест или экзамен education.attestation[].organization
        //    public string AttestationResult { get; set; }//Специальность / специализация education.attestation[].result
        //    public int AttestationYear { get; set; }//Год сдачи education.attestation[].year
        //}

        //public class Primary
        //{
        [Display(Name = "Высшее образование")]
        public string PrimaryName { get; set; }//Название учебного заведения education.primary[].name
        //    public string name_id { get; set; }
        [Display(Name = "Факультет")]
        public string PrimaryOrganization { get; set; }//Факультет education.primary[].organization
        //    public string organization_id { get; set; }
        [Display(Name = "Специальность")]
        public string PrimaryResult { get; set; }//Специальность / специализация education.primary[].result
        //    public object result_id { get; set; }
        [Display(Name = "Год Выпуска")]
        public int PrimaryYear { get; set; }//Год окончания education.primary[].year
        //}

        //public class Level
        //{
        //    public string id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string LevelName { get; set; }//Название уровня образования education.level.name
        //}

        //public class Education
        //{
        //    public List<Elementary> elementary { get; set; }
        //    public List<Additional> additional { get; set; }
        //    public List<Attestation> attestation { get; set; }
        //    public List<Primary> primary { get; set; }
        //    public Level level { get; set; }
        //}

        //public class Level2
        //{
        //    public string id { get; set; }
        //    public string name { get; set; }
        //}

        //public class Language
        //{
        //    public string id { get; set; }
        [Display(Name = "Знание языков")]
        public string LanguageName { get; set; }//Название языка language[].name
        [Display(Name = "Уровень знания")]
        public string LanguageLevel { get; set; }//Уровень знания языка language[].level
        //}

        //public class Area3
        //{
        //    public string url { get; set; }
        //    public string id { get; set; }
        [Display(Name = "Регион работодателя")]
        public string IndustryAreaName { get; set; }//Название региона работодателя experience[].area.name
        //}

        //public class Industry
        //{
        //    public string id { get; set; }
        [Display(Name = "Название отрасли компании")]
        public string IndustryName { get; set; }//Название отрасли experience[].industries[].name
        //}

        //public class Experience
        //{
        [Display(Name = "Название компании")]
        public string ExperienceCompany { get; set; }//Организация experience[].company
        //    public object company_id { get; set; }
        //    public Area3 area { get; set; }
        //    public string company_url { get; set; }
        //    public List<Industry> industries { get; set; }
        [Display(Name = "Должность")]
        public string ExperiencePosition { get; set; }//Должность experience[].position
        [Display(Name = "Дата начала работы")]
        public string ExperienceStart { get; set; }//Начало работы experience[].start
        [Display(Name = "Дата окончания работы")]
        public string ExperienceEnd { get; set; }//Окончание работы.null - если работает по настоящее время. experience[].end
        [Display(Name = "Выполняемые обязанности")]
        public string ExperienceDescription { get; set; }//Обязанности, функции, достижения experience[].description
                                                         //}

        //public class TotalExperience
        //{
        //    public int TotalExperienceMonths { get; set; }
        //}

        [Display(Name = "Дополнительная информация")]
        public string skills { get; set; }//Дополнительная информация, описание навыков в свободной форме skills =string/null

        //public class Citizenship
        //{
        //    public string url { get; set; }
        //    public string id { get; set; }
        [Display(Name = "Гражданство")]
        public string CitizenshipName { get; set; }//Гражданство citizenship[].name
        //}

        //public class WorkTicket
        //{
        //    public string url { get; set; }
        //    public string id { get; set; }
        [Display(Name = "Регион, для которого есть разрешение на работу")]
        public string WorkTicketName { get; set; }//Регион и разрешение на работу work_ticket[].name
                                                  //}

        //public class TravelTime
        //{
        //    public string id { get; set; }
        //    public string TravelTimeName { get; set; }//желательное время в пути до работы travel_time.name
        //}

        //public class Recommendation
        //{
        //    public string name { get; set; }
        //    public string position { get; set; }
        //    public string organization { get; set; }
        //}

        //public class ResumeLocale
        //{
        //    public string id { get; set; }
        //    public string name { get; set; }
        //}

        //public class Certificate
        //{
        //    public string title { get; set; }
        //    public string achieved_at { get; set; }
        //    public string type { get; set; }
        //    public string owner { get; set; }
        //    public string url { get; set; }
        //}

        //public class RootObject
        //{
        //    public User user { get; set; }
        //    //public Gender gender { get; set; }
        //    public Area area { get; set; }
        //    public Metro metro { get; set; }
        //    public RelocationType relocation { get; set; }
        //    public BusinessTripReadiness business_trip_readiness { get; set; }
        //    public List<Contact> contact { get; set; }
        //    //public List<Site> site { get; set; }
        //    public string title { get; set; }
        //    public Photo photo { get; set; }
        //    public List<Portfolio> portfolio { get; set; }
        //    public List<Specialization> specialization { get; set; }
        //    public Salary salary { get; set; }
        //    public List<Employment> employments { get; set; }
        //    public List<Schedule> schedules { get; set; }
        //    public Education education { get; set; }
        //    public List<Language> language { get; set; }
        //    public List<Experience> experience { get; set; }
        //    public TotalExperience total_experience { get; set; }
        //    public string skills { get; set; }
        //    public List<string> skill_set { get; set; }
        //    public List<Citizenship> citizenship { get; set; }
        //    public List<WorkTicket> work_ticket { get; set; }
        //    public TravelTime travel_time { get; set; }
        //    public List<Recommendation> recommendation { get; set; }
        //    public ResumeLocale resume_locale { get; set; }
        //    public List<Certificate> certificate { get; set; }
        //    public string alternate_url { get; set; }
        //    public string created_at { get; set; }
        //    public string updated_at { get; set; }
        //}

    public int? StateId { get; set; }
    public State State { get; set; }
    }
}