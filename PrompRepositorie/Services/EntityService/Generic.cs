using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repositories.Repository;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;



namespace PrompRepositories.Services.EntityService
{
    //public class Genericapp : Igenericapp<T> where T : class
    //{
    //    private IBaseRepository<T> repo;

    //    public IQueryable<T> Get()
    //    {
    //        return repo.All();
    //    }


    //    public T GetBy(Expression<Func<T, IEnumerable<T>>> expresion)
    //    {
    //        return repo.Find(expresion);
    //    }

    //    public void Insert(T entity)
    //    {
    //        repo.Create(entity);
    //        repo.Save();
    //    }

    //    public void Update(T entity)
    //    {
    //        repo.Update(T);
    //        repo.Save();
    //    }

    //    public void Delete(T entity)
    //    {
    //        repo.Delete(entity);
    //        repo.Save();
    //    }


    //}
}

