using Bank.Library.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bank.Library.Trade
{
    public class PublicTrade : ITradeManager
    {
        public string GetTradeRisk(double valor)
        {
            return valor < 1000000 ? Risk.LOWRISK.ToString() : Risk.MEDIUMRISK.ToString();
        }
    }
}
