using CompetentumWebApp.Models;
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
            return View();
        }

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
                .Include(p => p.language);
            return View(resumes.ToList());
        }

        [HttpGet]
        public ActionResult Create()//создание нового пользователя
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

            SelectList languages = new SelectList(db.language, "Id", "list_name");
            ViewBag.languages = languages;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Resume user)//получаем пользователя - данные введенные пользователем
        {
            //Добавляем пользователя в таблицу
            db.Resumes.Add(user);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("ResumeView");
        }

        [HttpGet]
        public ActionResult Edit(int? id)//получаем id редактируемого пользователя
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд пользователя
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
        public ActionResult Delete(int? id)//получаем id удаляемого пользователя
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд пользователя
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
            if (id == null)
            {
                return HttpNotFound();
            }

                Resume details = db.Resumes
                .Include(p => p.State)
                .Include(p => p.Currency)
                .Include(p => p.Schedule)
                .Include(p => p.EmploymentName)
                .Include(p => p.educationalLevel)
                .Include(p => p.languageLevel)
                .Include(p => p.language)
                .Include(p => p.Source)
                .Include(p => p.Gender).FirstOrDefault(p=>p.Id==id);

            return View(details);
        }

        //public static class Network
        //{
        //    public static object HttpContext { get; private set; }

        //    public static void AllowInvalidCertificate()
        //    {
        //        if (HttpContext.Current.Request.Url.Host == “localhost”)
        //        {
        //            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(allowCert);
        //        }
        //    }

        //    private static bool allowCert(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        //    {
        //        return true;
        //    }
        //}


        private static readonly HttpClient client = new HttpClient();
        
        //public async Task<ActionResult> HeadHunter()//создание нового пользователя
        [HttpGet]
        public ActionResult HeadHunter()//создание нового пользователя
        {
            /* https://api.hh.ru/specializations */



            //ServicePointManager.ServerCertificateValidationCallback +=
            //delegate (object sender, X509Certificate certificate, X509Chain chain,
            //       SslPolicyErrors sslPolicyErrors)
            //{
            //    return true;
            //};
            //WebClient client = new WebClient();
            //var data = client.DownloadString("https://api.hh.ru/resumes/429a025c0002c417ac0039ed1f325a56626932");

            string url = "https://api.hh.ru/resumes/429a025c0002c417ac0039ed1f325a56626932";
            //using (var webClient = new WebClient())
            //{
            //    webClient.QueryString.Add("format", "json");
            //    // Выполняем запрос по адресу и получаем ответ в виде строки
            //    var response = webClient.DownloadString(url);
            //}

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();

            //var responseString = await client.GetStringAsync("https://api.hh.ru/resumes/429a025c0002c417ac0039ed1f325a56626932");
            /* https://api.hh.ru/resumes/429a025c0002c417ac0039ed1f325a56626932 https://api.hh.ru/vacancies/18118213  */
            /* http://ip.jsontest.com/ */

            //var idResume = "429a025c0002c417ac0039ed1f325a56626932";
            //var urlString = "https://api.hh.ru/resumes/" + idResume.ToString();
            //var responseString = await urlString.GetStringAsync();
            return View();
        }

        //[HttpPost]
        //public async Task<ActionResult> HeadHunte(Resume user)//получаем пользователя - данные введенные пользователем
        //{
        //var responseString = await "http://www.example.com/recepticle.aspx".PostUrlEncodedAsync(new { thing1 = "hello", thing2 = "world" }).ReceiveString();
        //    //Добавляем пользователя в таблицу
        //    db.Resumes.Add(user);
        //    db.SaveChanges();
        //    // перенаправляем на главную страницу
        //    return RedirectToAction("Index");
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