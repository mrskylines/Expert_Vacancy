using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetentumWebApp.Models
{
    public class ExperienceJob
    {
        public int Id { get; set; }
        [Display(Name = "Название компании new")]
        public string ExperienceJobName { get; set; }
        [Display(Name = "Должность new")]
        public string ExperienceJobPosition { get; set; }
        [Display(Name = "Дата начала работы new")]
        public string ExperienceJobStart { get; set; }
        [Display(Name = "Дата окончания работы new")]
        public string ExperienceJobEnd { get; set; }

        //определение навигационных свойств
        public virtual ICollection<Resume> Resumes { get; set; }
        public ExperienceJob()
        {
            Resumes = new List<Resume>();//инициализируем коллекцию пустым списком
        }


        //public int EmployeeId { get; set; }

        //public string Experience_Job { get; set; }

        //public string Experience_Position { get; set; }

        //public string Experience_Start { get; set; }

        //public string Experience_End { get; set; }
    }
}