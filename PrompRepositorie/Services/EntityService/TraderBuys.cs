using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class TraderBuys : ContextConnection, ITraderBuys
    {
        private IBaseRepository<TraderBuy> TraderBuyrepo;

        public TraderBuys(IBaseRepository<TraderBuy> inputrepo)
        {
            TraderBuyrepo = inputrepo;
        }

        public TraderBuys()
        {
            TraderBuyrepo = new Repository<TraderBuy>(Context);
        }


        public IQueryable<TraderBuy> GetTraderBuys()
        {
            return TraderBuyrepo.All();
        }

        public TraderBuy GetTraderBuy(int id)
        {
            return TraderBuyrepo.Find(x => x.Id == id);
        }

        public void InsertTraderBuy(TraderBuy entity)
        {
            TraderBuyrepo.Create(entity);
            TraderBuyrepo.Save();
        }

        public void UpdateTraderBuy(TraderBuy entity)
        {
            TraderBuyrepo.Update(entity);
            Save();
        }

        public void DeleteTraderBuy(TraderBuy entity)
        {
            TraderBuyrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            TraderBuyrepo.Save();
        }
    }
}