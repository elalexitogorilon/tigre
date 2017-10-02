using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IProducto
    {
        IQueryable<Producto> GetProductos();
        Producto GetProducto(int id);
        void InsertProducto(Producto entity);
        void UpdateProducto(Producto entity);
        void DeleteProducto(Producto entity);
        void Save();
    }
}
