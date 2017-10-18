using System.Text;
using System.Threading.Tasks;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;
using System;
using System.Linq;


namespace BusinessObjects
{
    public class BOSellTrade
    {
            public BOResults Sell(int acountid, string symbol, int quantity, decimal value)
            {
                try
                {
                    var account = new Accounts();
                    var accountid = account.GetAccount(acountid);
                    if (accountid == null)
                    {
                        throw new Exception(" Account id : '" + acountid + "' does exist, please make sure you have the correct account to trade");

                    }

                    if (!HasStocksToSell(acountid, quantity, symbol))
                    {
                        throw new Exception(" Account id : '" + acountid + "' does not have suffient stocks for " + symbol);
                    }
                    var newsell = new DALTiger.TraderSell { Account = accountid
                                                        , Symbol = symbol
                                                        , Units = quantity
                                                        , Prices = value
                                                        , Total = (value* quantity)
                                                        ,Created =DateTime.Now, CreatedBy= "sa"  };
                    //get number Units, make sure they have units to sell, if not throw error 

                    new TraderSells().InsertTraderSell(newsell);
                    return new BOResults { Error = string.Empty, Message = string.Empty, Result = true };

                }
                catch (Exception error)
                {

                return new BOResults { Error = error.InnerException.ToString(), Message = error.Message, Result = false };

            }

        }

            public bool HasStocksToSell(int accountid, int quantiy, string symbol)
            {
                var currentstocks = new TraderBuys();
                var stocks = currentstocks.GetTraderBuys();
                var stocksbougth = stocks.Where(x => x.Accountid == accountid && x.Symbol.Contains(symbol)).Sum(p=>p.Units);
                if (stocksbougth >= quantiy)
                {
                    return true;
                }
                return false;
            }


    }
}
