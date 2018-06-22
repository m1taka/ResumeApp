using ResumeApp.Helper.External.Models;
using System.Data.Entity;

namespace ResumeApp.Helper
{
    public class ResumeDbContext:DbContext
    {
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<External.Models.Task> Tasks { get; set; }                
    }
}
