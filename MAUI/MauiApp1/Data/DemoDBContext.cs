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
        public DbSet<User> Users { get; set; }

        public DemoDBContext()
        {
            //SQLitePCL.Batteries_V2.Init();
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string dbPath = Path.Combine(FileSystem.AppDataDirectory, "notes.db3");

            //optionsBuilder
            //    .UseSqlite($"Filename={dbPath}");

            optionsBuilder
                .UseSqlServer("Data Source=localhost;Initial Catalog=MAUITest;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=Password2022;");
        }

    }

}

//https://learn.microsoft.com/en-us/ef/core/get-started/xamarin