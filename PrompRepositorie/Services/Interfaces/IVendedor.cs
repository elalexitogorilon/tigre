using System.Linq;
using DAL.DataAccess;

namespace PrompRepositories.Services.Interfaces
{
    public interface IVendedorService
    {
        IQueryable<Vendedor> GetVendedores();
        Vendedor GetVendedor(long id);
        void InsertVendedor(Vendedor entity);
        void UpdateVendedor(Vendedor entity);
        void DeleteVendedor(Vendedor entity);
        bool ValidateVendedoresCredentials(string contra, string usuario);
        void Save();
    }
}
