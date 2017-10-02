using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class TipoProveedores : ContextConnection, ITipoProveedor
    {
        private IBaseRepository<TipoDeProveedor> proveerepo;

        public TipoProveedores(IBaseRepository<TipoDeProveedor> proveerepo)
        {
            this.proveerepo = proveerepo;
        }

        public TipoProveedores()
        {
            proveerepo = new Repository<TipoDeProveedor>(Context);
        }
        public IQueryable<TipoDeProveedor> GetTipoProveedors()
        {
            return proveerepo.All();
        }
        public TipoDeProveedor GetTipoProveedor(int id)
        {
            return proveerepo.Find(x => x.Id == id); ;
        }

        public void InsertTipoDeProveedor(TipoDeProveedor entity)
        {
            proveerepo.Create(entity);
            proveerepo.Save();

        }
        public void UpdateTipoDeProveedor(TipoDeProveedor entity)
        {
            proveerepo.Update(entity);
            proveerepo.Save();
        }
        public void DeleteTipoDeProveedor(TipoDeProveedor entity)
        {
            proveerepo.Delete(entity);
            proveerepo.Save();
        }

    }
}
