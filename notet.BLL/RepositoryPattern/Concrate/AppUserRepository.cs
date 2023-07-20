using notet.BLL.RepositoryPattern.Base;
using notet.BLL.RepositoryPattern.Interfaces;
using notet.DAL.Context;
using notet.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notet.BLL.RepositoryPattern.Concrate
{
    public class AppUserRepository : Repository<AppUser>, IAppUser
    {
        public AppUserRepository(MyDbContext db) : base(db)
        {
        }
    }
}
