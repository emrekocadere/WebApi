using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EMREVIVO;Database=WebApi;Trusted_Connection=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_sClasses> student_SClasses { get; set; }
    }
}