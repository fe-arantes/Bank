using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Library.Trade
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
