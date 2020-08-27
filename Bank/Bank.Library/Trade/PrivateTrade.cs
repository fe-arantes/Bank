using Bank.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Library.Trade
{
    public class PrivateTrade : ITradeManager
    {
        public string GetTradeRisk(double valor)
        {
            return valor > 1000000 ? Risk.HIGHRISK.ToString() : Risk.UNDEFINED.ToString();
        }
    }
}
