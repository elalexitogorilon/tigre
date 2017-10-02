using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Proveedors : ContextConnection, IProveedor
    {
        private IBaseRepository<Proveedor> Proveedorrepo;

        public Proveedors(IBaseRepository<Proveedor> proveedor)
        {
            Proveedorrepo = proveedor;
        }

        public Proveedors()
        {
            Proveedorrepo = new Repository<Proveedor>(Context);
        }


        public IQueryable<Proveedor> GetProveedors()
        {
            return Proveedorrepo.All();
        }

        public Proveedor GetProveedor(int id)
        {
            return Proveedorrepo.Find(x => x.Id == id);
        }

        public void InsertProveedor(Proveedor entity)
        {
            Proveedorrepo.Create(entity);
            Proveedorrepo.Save();
        }

        public void UpdateProveedor(Proveedor entity)
        {
            Proveedorrepo.Update(entity);
            Save();
        }

        public void DeleteProveedor(Proveedor entity)
        {
            Proveedorrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            Proveedorrepo.Save();
        }
    }
}
