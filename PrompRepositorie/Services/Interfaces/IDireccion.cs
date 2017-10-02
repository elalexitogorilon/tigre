using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IDireccion
    {
        IQueryable<Direccion> GetDireccions();
        Direccion GetDireccion(int id);
        void InsertDireccion(Direccion entity);
        void UpdateDireccion(Direccion entity);
        void DeleteDireccion(Direccion entity);
    }
}
