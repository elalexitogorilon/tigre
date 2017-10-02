using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALocean.DataAccess;

namespace PrompRepositories.Services.Interfaces
{
    public interface IOceanProducto
    {
        IQueryable<Producto> GetProductos();
        Producto GetProducto(int id);
        void InsertProducto(Producto entity);
        void UpdateProducto(Producto entity);
        void DeleteProducto(Producto entity);
        void Save();
    }
}
