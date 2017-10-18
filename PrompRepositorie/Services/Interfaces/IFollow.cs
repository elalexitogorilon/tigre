using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IFollow
    {
        IQueryable<DALTiger.Following> GetFollow();
        DALTiger.Following GetFollow(int id);

        DALTiger.Following GetFollowedByUserId(int id);
        void InsertFollow(DALTiger.Following entity);
        void UpdateFollow(DALTiger.Following entity);
        void DeleteFollow(DALTiger.Following entity);
        void Save();
        
    }
}
