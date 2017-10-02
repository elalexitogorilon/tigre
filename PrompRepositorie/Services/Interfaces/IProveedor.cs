using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IProveedor
    {
        IQueryable<Proveedor> GetProveedors();
        Proveedor GetProveedor(int id);
        void InsertProveedor(Proveedor entity);
        void UpdateProveedor(Proveedor entity);
        void DeleteProveedor(Proveedor entity);

        void Save();
    }
}
