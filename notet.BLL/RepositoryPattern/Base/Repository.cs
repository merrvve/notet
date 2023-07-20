using Microsoft.EntityFrameworkCore;
using notet.BLL.RepositoryPattern.Interfaces;
using notet.DAL.Context;
using notet.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace notet.BLL.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MyDbContext _db;
        protected DbSet<T> table;
        public Repository(MyDbContext db) {
            _db = db;
            table=db.Set<T>();

        }

        private void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T entity)
        {
            table.Add(entity);
            Save();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }

        public void Delete(int id)
        {
            T entity = GetById(id);
            entity.DataStatus = MODEL.Enums.DataStatus.Deleted;
            table.Update(entity);
            Save();
        }

        public List<T> GetActives()
        {
            return table.Where(x => x.DataStatus == MODEL.Enums.DataStatus.Active).ToList();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public List<T> GetByExp(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Update(T entity)
        {
            table.Update(entity);
            Save();
        }

      
        public T Default(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }
    }
}
