using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface ITelephone
    {
        IQueryable<Telefono> GetTelefonos();
        Telefono GetTelefono(int id);
        void InsertTelefono(Telefono entity);
        void UpdateTelefono(Telefono entity);
        void DeleteTelefono(Telefono entity);
    }
}
