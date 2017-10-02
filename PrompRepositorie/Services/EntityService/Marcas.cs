using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;


namespace PrompRepositories.Services.EntityService
{
    public class Marcas : ContextConnection, IMarca
    {
        private IBaseRepository<Marca> marcarepo;

        public Marcas(IBaseRepository<Marca> mrcrepor)
        {
            ContextOcean = false;
            marcarepo = mrcrepor;
        }

        public Marcas()
        {
            ContextOcean = false;
            marcarepo = new Repository<Marca>(Context);
        }


        public IQueryable<Marca> GetMarcas()
        {
            return marcarepo.All();
        }

        public Marca GetMarca(int id)
        {
            return marcarepo.Find(x => x.Id == id);
        }

        public void InsertMarca(Marca entity)
        {
            marcarepo.Create(entity);
            marcarepo.Save();
        }

        public void UpdateMarca(Marca entity)
        {
            marcarepo.Update(entity);
            Save();
        }

        public void DeleteMarca(Marca entity)
        {
            marcarepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            marcarepo.Save();
        }
    }
}
