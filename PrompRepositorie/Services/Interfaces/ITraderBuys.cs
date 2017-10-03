using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface ITraderBuys
    {
        IQueryable<TraderBuy> GetTraderBuys();
        TraderBuy GetTraderBuy(int id);
        void InsertTraderBuy(TraderBuy entity);
        void UpdateTraderBuy(TraderBuy entity);
        void DeleteTraderBuy(TraderBuy entity);
        void Save();
    }
}