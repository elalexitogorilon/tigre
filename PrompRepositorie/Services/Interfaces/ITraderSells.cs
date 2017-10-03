using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface ITraderSells
    {
        IQueryable<TraderSell> GetTraderSells();
        TraderSell GetTraderSell(int id);
        void InsertTraderSell(TraderSell entity);
        void UpdateTraderSell(TraderSell entity);
        void DeleteTraderSell(TraderSell entity);
        void Save();
    }
}
