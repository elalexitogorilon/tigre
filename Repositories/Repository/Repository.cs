using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Repositories.BaseInterface;
//using DALPromp = DAL.DataAccess;
//using DALOcen = OceanikarDAL.EF;
using Newoceandal =  DAL.DataAccess;
using DALocean.DataAccess;

namespace Repositories.Repository
{
    public class Repository<T> : IBaseRepository<T>
        where T : class
    {
        protected DbContext Context = null;
        private bool shareContext = false;
       

        public Repository(DbContext context)
        {
            Context = context;
            shareContext = true;           
        }

        public Repository()
        {
            
            Context = new Newoceandal.PrompEntitiesDev();
        }

        public Repository(bool ocean =  true)
        {
          
            if (ocean)
            {
                Context = new NewOceanicarefEntities();
                return;
            }

            Context = new Newoceandal.PrompEntitiesDev();//   oceanicaProdEntities();
        }


        protected DbSet<T> DbSet
        {
            get
            {
                return Context.Set<T>();
            }
        }

        public void Dispose()
        {
            if (shareContext && (Context != null))
                Context.Dispose();
        }


        public virtual IQueryable<T> All()
        {
            return DbSet.AsQueryable();
        }

        public virtual IQueryable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable<T>();
        }

        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeExpressions)
        {
            IQueryable<T> set = DbSet.Where(predicate);
            foreach (var includeExpression in includeExpressions)
            {
                set = set.Include(includeExpression);
            }
            return set;
        }

        public void Create(T entity)
        {
            var newEntry = DbSet.Add(entity);
            if (!shareContext)
                Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            if (!shareContext)
            {
                Context.SaveChanges();
            }
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            var objects = Filter(predicate);
            foreach (var obj in objects)
                DbSet.Remove(obj);
            if (!shareContext)
            {
               Context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            var entry = Context.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
            if (!shareContext)
            {
               Context.SaveChanges();
            }
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public virtual IEnumerable<T> ExecuteStoredproc(string command, params object[] paramenters)
        {
            return Context.Database.SqlQuery<T>(command, paramenters);
        }

    }
}
