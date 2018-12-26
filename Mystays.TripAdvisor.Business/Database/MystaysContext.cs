using Microsoft.EntityFrameworkCore;
using Mystays.TripAdvisor.Business.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.Database
{
    public class MystaysContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=TestDB;User Id=sa;Password=rtba@123;Trusted_Connection=True;");
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
