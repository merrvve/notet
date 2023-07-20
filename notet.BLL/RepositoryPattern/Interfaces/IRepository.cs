using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using notet.MODEL.Entities;

namespace notet.BLL.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        List<T> GetActives();
        T GetById(int id);
        List<T> GetByExp(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);

        T Default(Expression<Func<T, bool>> exp);
    }
}
