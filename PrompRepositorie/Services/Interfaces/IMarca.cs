using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;


namespace PrompRepositories.Services.Interfaces
{
    public interface IMarca
    {
        IQueryable<Marca> GetMarcas();
        Marca GetMarca(int id);
        void InsertMarca(Marca entity);
        void UpdateMarca(Marca entity);
        void DeleteMarca(Marca entity);
       
        void Save();
    }
}
