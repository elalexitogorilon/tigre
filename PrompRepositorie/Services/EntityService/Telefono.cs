using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    /// <summary>
    /// 
    /// </summary>
    public class Telefonos : ContextConnection, ITelephone
    {
        private IBaseRepository<Telefono> telefonorepo;

        public Telefonos(IBaseRepository<Telefono> telefono)
        {
            telefonorepo = telefono;
        }

        public Telefonos()
        {
            telefonorepo = new Repository<Telefono>(Context);
        }


        public IQueryable<Telefono> GetTelefonos()
        {
            return telefonorepo.All();
        }

        public Telefono GetTelefono(int id)
        {
            return telefonorepo.Find(x => x.Id == id);
        }

        public void InsertTelefono(Telefono entity)
        {
            telefonorepo.Create(entity);
            telefonorepo.Save();
        }

        public void UpdateTelefono(Telefono entity)
        {
            telefonorepo.Update(entity);
            Save();
        }

        public void DeleteTelefono(Telefono entity)
        {
            telefonorepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            telefonorepo.Save();
        }
    }
}
