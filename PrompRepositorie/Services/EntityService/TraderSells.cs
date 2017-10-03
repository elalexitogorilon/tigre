using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class TraderSells : ContextConnection, ITraderSells
    {
        private IBaseRepository<TraderSell> traderSellrepo;

        public TraderSells(IBaseRepository<TraderSell> inputrepo)
        {
            traderSellrepo = inputrepo;
        }

        public TraderSells()
        {
            traderSellrepo = new Repository<TraderSell>(Context);
        }


        public IQueryable<TraderSell> GetTraderSells()
        {
            return traderSellrepo.All();
        }

        public TraderSell GetTraderSell(int id)
        {
            return traderSellrepo.Find(x => x.Id == id);
        }

        public void InsertTraderSell(TraderSell entity)
        {
            traderSellrepo.Create(entity);
            traderSellrepo.Save();
        }

        public void UpdateTraderSell(TraderSell entity)
        {
            traderSellrepo.Update(entity);
            Save();
        }

        public void DeleteTraderSell(TraderSell entity)
        {
            traderSellrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            traderSellrepo.Save();
        }
    }
}
