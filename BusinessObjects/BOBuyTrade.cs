using System.Text;
using System.Threading.Tasks;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;
using System;

namespace BusinessObjects
{
    public class BOBuyTrade
    {
        public BOResults Buy(int acountid, string symbol, int quantity, decimal value)
        {
            try
            {
                var account = new Accounts();
                var accountid = account.GetAccount(acountid);
                if (accountid == null)
                {
                    throw new Exception(" Account id : '" + acountid + "' does exist, please make sure you have the correct account to trade");

                }
                var newbuy = new DALTiger.TraderBuy { Account = accountid
                                                    , Symbol = symbol
                                                    , Units = quantity
                                                    , Prices = value
                                                    , Total = (value* quantity)
                                                    ,Created =DateTime.Now, CreatedBy= "sa"  };

                new TraderBuys().InsertTraderBuy(newbuy);
                return new BOResults { Error = string.Empty, Message = string.Empty, Result = true };

            }
            catch (Exception error)
            {

                return new BOResults { Error = error.InnerException.ToString(), Message = error.Message, Result = false };

            }

        }
    }
        
}
