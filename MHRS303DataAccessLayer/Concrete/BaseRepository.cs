using MHRS303DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303DataAccessLayer.Concrete
{
    public class BaseRepository<T, Id> : IBaseRepository<T, Id> where T : class, new()
    {
        protected readonly MyContext _myContext;
        // readonly (Dışarıdan kimse set edemesin diye kullandık).

        public BaseRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public bool Add(T entity)
        {
            try
            {
                _myContext.Set<T>().Add(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _myContext.Set<T>().Remove(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter, string includeEntities = null)
        {
            try
            {
                IQueryable<T> query = _myContext.Set<T>();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (includeEntities != null)
                {
                    var includes = includeEntities.Split(','); // İlişkili olduğu kaç tane tablo varsa onların isimlerini virgül koyarak bana
                    // includeEntities gönderecek. Gelen bu bilgiyi virgülden itibaren ayırın ve o tabloya inner join edeceğiz.

                    foreach (var item in includes)
                    {
                        query = query.Include(item);
                    }
                }
                return query;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetById(Id id)
        {
            try
            {
                return _myContext.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeEntities = null)
        {
            try
            {
                IQueryable<T> query = _myContext.Set<T>();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (includeEntities != null)
                {
                    var includes = includeEntities.Split(','); // İlişkili olduğu kaç tane tablo varsa onların isimlerini virgül koyarak bana
                    // includeEntities gönderecek. Gelen bu bilgiyi virgülden itibaren ayırın ve o tabloya inner join edeceğiz.

                    foreach (var item in includes)
                    {
                        query = query.Include(item);
                    }
                }
                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _myContext.Set<T>().Update(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
