using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace garage_assistant
{

    public class ApplicationContext : DbContext
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<Details> Details { get; set; }

        public DbSet<Workers> Workers { get; set; }

        public DbSet<Docs> Docs{ get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=garassistdb;Trusted_Connection=True;");
        }
    }
}
