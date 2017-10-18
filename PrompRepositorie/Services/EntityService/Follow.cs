using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Follows : ContextConnection, IFollow
    {
        private IBaseRepository<Following> Followrepo;

        public Follows(IBaseRepository<Following> inputrepo)
        {
            Followrepo = inputrepo;
        }

        public Follows()
        {
            Followrepo = new Repository<Following>(Context);
        }


        public IQueryable<Following> GetFollow()
        {
            return Followrepo.All();
        }

        public Following GetFollow(int id)
        {
            return Followrepo.Find(x => x.Id == id);
        }

        public Following GetFollowedByUserId(int id)
        {
            return Followrepo.Find(x => x.FollowingAccountID==id);
        }

        public void InsertFollow(Following entity)
        {
            Followrepo.Create(entity);
            Followrepo.Save();
        }

        public void UpdateFollow(Following entity)
        {
            Followrepo.Update(entity);
            Save();
        }

        public void DeleteFollow(Following entity)
        {
            Followrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            Followrepo.Save();
        }
    }
}
