using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompetentumWebApp.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<EmploymentName> EmploymentNames { get; set; }
        public DbSet<educationalLevel> educationalLevels { get; set; }
        public DbSet<languageLevel> languageLevels { get; set; }
        public DbSet<language> languages { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ExperienceJob> ExperienceJobs { get; set; }

        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyState> VacancyStates { get; set; }
    }
}