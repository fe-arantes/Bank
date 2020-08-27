using Bank.Library.Trade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Library.Enums
{
    public enum ClientSector
    {
        Public = 1,
        Private = 2
    }

    static class SectorExtension
    {
        public static ITradeManager GetSector(this ClientSector clientSector)
        {
            return clientSector switch
            {
                ClientSector.Public => new PublicTrade(),
                ClientSector.Private => new PrivateTrade(),
                _ => null,
            };
        }
    }

}
