using System.Text;
using System.Threading.Tasks;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;
using System;

namespace BusinessObjects
{
    public class BOFollowing
    {
        public BOResults Following(int followerid, int followedaccountid )
        {
            try
            {
                var followeraccount = new Accounts();
                var followeracc = followeraccount.GetAccount(followerid);
                if (followeracc == null)
                {
                    throw new Exception(" Account id : '" + followerid + "' does exist, please make sure you have the correct account ");

                }


                var followedaccount = followeraccount.GetAccount(followedaccountid);
                if (followedaccount == null)
                {
                    throw new Exception(" Following id : '" + followedaccountid + "' does exist, please make sure you have the correct following account id");

                }


                var newfollowing = new DALTiger.Following
                {
                    Account = followeracc,
                    FollowingAccountID = followedaccountid,
                    Created = DateTime.Now,
                    CreatedBy = "sa"
                };

                new Follows().InsertFollow(newfollowing);
                return new BOResults { Error = string.Empty, Message = string.Empty, Result = true };

            }
            catch (Exception error)
            {

                return new BOResults { Error = error.InnerException.ToString(), Message = error.Message, Result = false };
            }

        }
    }
}
