using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public  class Direcciones : ContextConnection, IDireccion
    {

        private IBaseRepository<Direccion> direccionrepo;

        public Direcciones(IBaseRepository<Direccion> direccion)
        {
            direccionrepo = direccion;
        }

        public Direcciones()
        {
            direccionrepo = new Repository<Direccion>(Context);
        }


        public IQueryable<Direccion> GetDireccions()
        {
            return direccionrepo.All();
        }

        public Direccion GetDireccion(int id)
        {
            return direccionrepo.Find(x => x.Id == id);
        }

        public void InsertDireccion(Direccion entity)
        {
            direccionrepo.Create(entity);
            direccionrepo.Save();
        }

        public void UpdateDireccion(Direccion entity)
        {
            direccionrepo.Update(entity);
            direccionrepo.Save();
        }

        public void DeleteDireccion(Direccion entity)
        {
            direccionrepo.Delete(entity);
            direccionrepo.Save();
        }

         
    }
}
