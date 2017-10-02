using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface ITipoProveedor
    {
        IQueryable<TipoDeProveedor> GetTipoProveedors();
        TipoDeProveedor GetTipoProveedor(int id);
        void InsertTipoDeProveedor(TipoDeProveedor entity);
        void UpdateTipoDeProveedor(TipoDeProveedor entity);
        void DeleteTipoDeProveedor(TipoDeProveedor entity);

       
    }
}
