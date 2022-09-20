using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DemoDBContext()
        {
            SQLitePCL.Batteries_V2.Init();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "notess.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }

    }

}

//https://learn.microsoft.com/en-us/ef/core/get-started/xamarin