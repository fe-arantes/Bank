using Bank.Library.Enums;
using Bank.Library.Trade;
using System;
using System.Collections.Generic;

namespace Bank.Library
{
    public class BankTrade
    {
        public List<string> GetTradeCategories(List<ITrade> portfolio)
        {
            var categories = new List<string>();

            foreach (var trade in portfolio)
            {
                var clientSector = (ClientSector)Enum.Parse(typeof(ClientSector), trade.ClientSector);

                var tradeManager = new TradeManager(clientSector.GetSector());

                categories.Add(tradeManager.GetTradeRisk(trade.Value));
            }

            return categories;
        }
    }
}
