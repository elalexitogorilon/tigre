using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Repositories.BaseInterface;
//using DALPromp = DALTiger;
//using DALOcen = OceanikarDAL.EF;
using  DALTiger;


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
            
            Context = new TraderTigerContainer();
        }

        public Repository(bool ocean =  true)
        {
          
            if (ocean)
            {
                Context = new TraderTigerContainer();
                return;
            }

            Context = new TraderTigerContainer();//   
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
