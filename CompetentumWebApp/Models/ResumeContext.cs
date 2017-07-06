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
    }
}