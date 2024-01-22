using Microsoft.EntityFrameworkCore;
using SoftitoProject_01.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftitoProject_01.DataLayer
{
    public class ExampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SINAN;Database=Example;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Jobber> Jobbers { get; set; }
    }
}