using Microsoft.EntityFrameworkCore;
using notet.MODEL.Entities;
using notet.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notet.DAL.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("856575");
            modelBuilder.Entity<AppUser>().HasData(
                 new AppUser() { Id = 1, UserName = "admin", Password = password1, Role = Role.admin },
                 new AppUser() { Id = 2, UserName = "merve", Password = password2, Role = Role.user });
        }
    }
}
