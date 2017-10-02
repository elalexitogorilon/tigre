using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Vehiculos : ContextConnection, IVehiculo
    {
        private IBaseRepository<Vehiculo> vehiculorepo;

        public Vehiculos(IBaseRepository<Vehiculo> mrcrepor)
        {
            vehiculorepo = mrcrepor;
        }

        public Vehiculos()
        {
            vehiculorepo = new Repository<Vehiculo>(Context);
        }


        public IQueryable<Vehiculo> GetVehiculos()
        {
            return vehiculorepo.All();
        }

        public Vehiculo GetVehiculo(int id)
        {
            return vehiculorepo.Find(x => x.Id == id);
        }

        public void InsertVehiculo(Vehiculo entity)
        {
            vehiculorepo.Create(entity);
            vehiculorepo.Save();
        }

        public void UpdateVehiculo(Vehiculo entity)
        {
            vehiculorepo.Update(entity);
            Save();
        }

        public void DeleteVehiculo(Vehiculo entity)
        {
            vehiculorepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            vehiculorepo.Save();
        }
    }
}
