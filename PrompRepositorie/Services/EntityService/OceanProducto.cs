using System.Linq;
using DALocean.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class OceanProducto : ContextConnection, IOceanProducto
    {
        private IBaseRepository<Producto> productorepo;


        public OceanProducto (IBaseRepository<Producto> productorepo)
        {
            ContextOcean = true;
            this.productorepo = productorepo;
        }

        public OceanProducto()
        {
            ContextOcean = true;
            productorepo = new Repository<Producto>(Context);
        }


        public IQueryable<Producto> GetProductos()
        {

            var prods = productorepo.All();
            return prods;
        }
        public Producto GetProducto(int id)
        {
            return productorepo.Find(x => x.Productos_pk == id);
        }
        public void InsertProducto(Producto entity)
        {

        }
        public void UpdateProducto(Producto entity)
        { }
        public void DeleteProducto(Producto entity)
        { }
        public void Save()
        {

        }
    }
}
