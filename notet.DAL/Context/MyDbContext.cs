using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notet.MAP.Configuration;
using notet.MAP.Configuration.AppUserConfiguration;
using notet.MODEL.Entities;
using notet.DAL.Initializer;

namespace notet.DAL.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new AppUserConfiguration()) ;
            DataInitializer.Seed(modelBuilder);
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
