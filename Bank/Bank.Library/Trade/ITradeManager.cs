using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Library.Trade
{
    public interface ITradeManager
    {
        string GetTradeRisk(double valor);
    }
}
