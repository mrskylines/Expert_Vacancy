﻿using CompetentumWebApp.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Newtonsoft.Json;

namespace AdminLteMvc.Controllers
{
    /// <summary>
    /// This is an example controller using the AdminLTE NuGet package's CSHTML templates, CSS, and JavaScript
    /// You can delete these, or use them as handy references when building your own applications
    /// </summary>
    public class AdminLteController : Controller
    {
        /// <summary>
        /// The home page of the AdminLTE demo dashboard, recreated in this new system
        /// </summary>
        /// <returns></returns>
        ResumeContext db = new ResumeContext();
        public ActionResult Index()
        {
            var vacancies = db.Vacancies
                .Include(v => v.VacancyState);
            return View(vacancies.ToList());
        }

        [HttpGet]
        public ActionResult VacancyCreate()//создание новой вакансии
        {
            SelectList Vacancystates = new SelectList(db.VacancyStates, "Id", "VacancyStateName");
            ViewBag.VacancyStates = Vacancystates;

            return View();
        }

        [HttpPost]
        public ActionResult VacancyCreate(Vacancy newvacancy)//получаем введенные данные по вакансии
        {
            //Добавляем вакансию в таблицу
            db.Vacancies.Add(newvacancy);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult VacancyEdit(int? id)//получаем id редактируемой вакансии
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд вакансию
            Vacancy newvacancy = db.Vacancies.Find(id);
            if (newvacancy != null)
            {
                SelectList Vacancystates = new SelectList(db.VacancyStates, "Id", "VacancyStateName");
                ViewBag.VacancyStates = Vacancystates;

                return View(newvacancy);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult VacancyEdit(Vacancy newvacancy)//получаем введенные пользователем данные через модель Vacancy
        {
            db.Entry(newvacancy).State = EntityState.Modified;//устанавливаем для этой модели статус Modified
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult VacancyDetails(int? id)
        {
            Vacancy Vacancydetails = db.Vacancies.Find(id);

            if (id == null)
            {
                return HttpNotFound();
            }
            
            //ViewBag.Vacancys = db.Vacancys.ToList();

            return View(Vacancydetails);
        }

        [HttpGet]
        public ActionResult VacancyDelete(int? id)//получаем id удаляемого резюме
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд вакансию
            Vacancy newvacancy = db.Vacancies.Find(id);
            if (newvacancy != null)
            {
                db.Vacancies.Remove(newvacancy);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////          РЕЗЮМЕ          //////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public ActionResult ResumeView()
        {
            var resumes = db.Resumes
                .Include(p => p.State)
                .Include(p => p.Currency)
                .Include(p => p.Schedule)
                .Include(p => p.EmploymentName)
                .Include(p => p.educationalLevel)
                .Include(p => p.languageLevel)
                .Include(p => p.language)
                .Include(p => p.Source)
                .Include(p => p.Gender);
            return View(resumes.ToList());
        }

        [HttpGet]
        public ActionResult Create()//создание нового резюме
        {
            SelectList states = new SelectList(db.States, "Id", "StateName");
            ViewBag.States = states;

            SelectList currencies = new SelectList(db.Currencies, "Id", "CurrencyName");
            ViewBag.Currencies = currencies;

            SelectList schedules = new SelectList(db.Schedules, "Id", "ScheduleName");
            ViewBag.Schedules = schedules;

            SelectList empoymentnames = new SelectList(db.EmploymentNames, "Id", "Employement_Name");
            ViewBag.EmploymentNames = empoymentnames;

            SelectList educationallevels = new SelectList(db.educationalLevels, "Id", "name");
            ViewBag.educationalLevels = educationallevels;

            SelectList languagelevels = new SelectList(db.languageLevels, "Id", "Level_name");
            ViewBag.languageLevels = languagelevels;

            SelectList languages = new SelectList(db.languages, "Id", "list_name");
            ViewBag.languages = languages;

            SelectList sources = new SelectList(db.Sources, "Id", "SourceName");
            ViewBag.Sources = sources;

            SelectList genders = new SelectList(db.Genders, "Id", "GenderName");
            ViewBag.Genders = genders;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Resume user)//получаем введенные данные
        {
            //Добавляем пользователя в таблицу
            db.Resumes.Add(user);
            db.SaveChanges();
            // перенаправляем на страницу с БД Резюме
            return RedirectToAction("ResumeView");
        }

        [HttpGet]
        public ActionResult Edit(int? id)//получаем id редактируемого резюме
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд резюме
            Resume user = db.Resumes.Find(id);
            if (user != null)
            {
                SelectList states = new SelectList(db.States, "Id", "StateName");
                ViewBag.States = states;

                SelectList currencies = new SelectList(db.Currencies, "Id", "CurrencyName");
                ViewBag.Currencies = currencies;

                SelectList schedules = new SelectList(db.Schedules, "Id", "ScheduleName");
                ViewBag.Schedules = schedules;

                SelectList empoymentnames = new SelectList(db.EmploymentNames, "Id", "Employement_Name");
                ViewBag.EmploymentNames = empoymentnames;

                SelectList educationallevels = new SelectList(db.educationalLevels, "Id", "name");
                ViewBag.educationalLevels = educationallevels;

                SelectList languagelevels = new SelectList(db.languageLevels, "Id", "Level_name");
                ViewBag.languageLevels = languagelevels;

                SelectList languages = new SelectList(db.languages, "Id", "list_name");
                ViewBag.languages = languages;

                SelectList sources = new SelectList(db.Sources, "Id", "SourceName");
                ViewBag.Sources = sources;

                SelectList genders = new SelectList(db.Genders, "Id", "GenderName");
                ViewBag.Genders = genders;

                return View(user);
            }
            return RedirectToAction("ResumeView");
        }

        [HttpPost]
        public ActionResult Edit(Resume user)//получаем введенные пользователем данные через модель Resume
        {
            db.Entry(user).State = EntityState.Modified;//устанавливаем для этой модели статус Modified
            db.SaveChanges();
            return RedirectToAction("ResumeView");
        }

        [HttpGet]
        public ActionResult Delete(int? id)//получаем id удаляемого резюме
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд резюме
            Resume user = db.Resumes.Find(id);
            if (user != null)
            {
                db.Resumes.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("ResumeView");
        }

        public ActionResult Details(int? id)
        {

            Resume details = db.Resumes
            .Include(p => p.State)
            .Include(p => p.Currency)
            .Include(p => p.Schedule)
            .Include(p => p.EmploymentName)
            .Include(p => p.educationalLevel)
            .Include(p => p.languageLevel)
            .Include(p => p.language)
            .Include(p => p.Source)
            .Include(p => p.Gender).FirstOrDefault(p => p.Id == id);

            if (id == null)
            {
                return HttpNotFound();
            }

            return View(details);
        }

        //private static readonly HttpClient client = new HttpClient();

        //[HttpGet]
        //public ActionResult HeadHunter()//добавление нового резюме с HeadHunter
        //{
        //    string url = "https://api.hh.ru/resumes/cf8969d20003d712b50039ed1f464731504c58";
        //    using (var webClient = new WebClient())
        //    {
        //        webClient.QueryString.Add("format", "json");
        //        // Выполняем запрос по адресу и получаем ответ в виде строки

        //        webClient.Headers.Add("User-Agent: troc-nikitaApp/1.0 (troc-nikita@yandex.com)");
        //        // Выполняем запрос по адресу и получаем ответ в виде строки
        //        webClient.Encoding = System.Text.Encoding.UTF8;

        //        var response = webClient.DownloadString(url);

        //        Resume user = new Resume();

        //        user = JsonConvert.DeserializeObject<Resume>(response);
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult HeadHunter(Resume user)//получаем пользователя - данные введенные пользователем
        //{
        //    //var responseString = await "http://www.example.com/recepticle.aspx".PostUrlEncodedAsync(new { thing1 = "hello", thing2 = "world" }).ReceiveString();
        //    //Добавляем пользователя в таблицу
        //    db.Resumes.Add(user);
        //    db.SaveChanges();
        //    // перенаправляем на главную страницу
        //    return RedirectToAction("ResumeView");
        //}

    /// <summary>
    /// The color page of the AdminLTE demo, demonstrating the AdminLte.Color enum and supporting methods
    /// </summary>
    /// <returns></returns>
    public ActionResult Colors()
        {
            return View();
        }
    }
}