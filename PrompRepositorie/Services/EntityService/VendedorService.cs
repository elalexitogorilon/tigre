
using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class VendedorService : ContextConnection,IVendedorService
    {
        private IBaseRepository<Vendedor> vendedorrepo;

        public VendedorService (IBaseRepository<Vendedor>vndrepo)
        {
                ContextOcean = false;
                vendedorrepo = vndrepo;
        }

        public VendedorService ()
        {
            ContextOcean = false;
            vendedorrepo = new Repository<Vendedor>(Context);
        }


        public IQueryable<Vendedor> GetVendedores()
        {
            return vendedorrepo.All();
        }

        public Vendedor GetVendedor(long id)
        {
            return vendedorrepo.Find(x=>x.ID ==id);
        }

        public void InsertVendedor(Vendedor entity)
        {
            vendedorrepo.Create(entity);
        }

        public void UpdateVendedor(Vendedor entity)
        {
            vendedorrepo.Update(entity);
        }

        public bool ValidateVendedoresCredentials (string contra, string usuario)
        {
            var findusuario=    vendedorrepo.Find(v => v.CuentaUsuarios.FirstOrDefault(u => u.NombreUsuario == usuario && u.Contrasena == contra) != null);
            return (findusuario!=null);
        }


        public void DeleteVendedor(Vendedor entity)
        {
            vendedorrepo.Delete(entity);
        }

        public void Save()
        {
            vendedorrepo.Save();
        }
    }
}
