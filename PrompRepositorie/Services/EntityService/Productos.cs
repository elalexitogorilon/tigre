using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Productos : ContextConnection, IProducto
    {
        private IBaseRepository<Producto> productorepo;

        public Productos(IBaseRepository<Producto> producrepor)
        {
            productorepo = producrepor;
        }

        public Productos()
        {
            productorepo = new Repository<Producto>(Context);
        }


        public IQueryable<Producto> GetProductos()
        {
            return productorepo.All();
        }

        public Producto GetProducto(int id)
        {
            return productorepo.Find(x => x.Id == id);
        }

        public void InsertProducto(Producto entity)
        {
            productorepo.Create(entity);
            productorepo.Save();
        }

        public void UpdateProducto(Producto entity)
        {
            productorepo.Update(entity);
            Save();
        }

        public void DeleteProducto(Producto entity)
        {
            productorepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            productorepo.Save();
        }
    }
}
