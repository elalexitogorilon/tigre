﻿using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Persons : ContextConnection, IPerson
    {
        private IBaseRepository<Person> personrepo;

        public Persons(IBaseRepository<Person> producrepor)
        {
            personrepo = producrepor;
        }

        public Persons()
        {
            personrepo = new Repository<Person>(Context);
        }


        public IQueryable<Person> GetPersons()
        {
            return personrepo.All();
        }

        public Person GetPerson(int id)
        {
            return personrepo.Find(x => x.ID == id);
        }

        public void InsertPerson(Person entity)
        {
            personrepo.Create(entity);
            personrepo.Save();
        }

        public void UpdatePerson(Person entity)
        {
            personrepo.Update(entity);
            Save();
        }

        public void DeletePerson(Person entity)
        {
            personrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            personrepo.Save();
        }
    }
}
