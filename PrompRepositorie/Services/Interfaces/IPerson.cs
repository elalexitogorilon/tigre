using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IPerson
    {
        IQueryable<Person> GetPersons();
        Person GetPerson(int id);
        void InsertPerson(Person entity);
        void UpdatePerson(Person entity);
        void DeletePerson(Person entity);
        void Save();
    }
}
