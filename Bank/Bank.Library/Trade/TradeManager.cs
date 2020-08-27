using Bank.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Library.Trade
{
    public class TradeManager
    {
        private ITradeManager tradeManager { get; set; }

        public TradeManager(ITradeManager tradeManager)
        {
            this.tradeManager = tradeManager;
        }

        public string GetTradeRisk(double value)
        {
            return tradeManager == null ? Risk.UNDEFINED.ToString() : tradeManager.GetTradeRisk(value);
        }
    }
}
