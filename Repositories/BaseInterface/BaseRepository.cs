using System;
using System.Collections.Generic;
using System.Linq;

using System.Linq.Expressions;


namespace Repositories.BaseInterface
{
    /// <summary>
    /// BaseRepository
    /// </summary>   
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All();

        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        T Find(Expression<Func<T, bool>> predicate);       

        IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate,params Expression<Func<T, object>>[] includeExpressions);

        void Create(T entity);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> predicate);

        void Update(T entity);         

        void Save ();

        IEnumerable<T> ExecuteStoredproc(string command, params object[] paramenters);
    }
}
