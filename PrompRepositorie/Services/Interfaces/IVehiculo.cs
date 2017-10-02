using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IVehiculo
    {
        IQueryable<Vehiculo> GetVehiculos();
        Vehiculo GetVehiculo(int id);
        void InsertVehiculo(Vehiculo entity);
        void UpdateVehiculo(Vehiculo entity);
        void DeleteVehiculo(Vehiculo entity);

        void Save();
    }
}
