using Bank.Library;
using Bank.Library.Trade;
using System;
using System.Collections.Generic;

namespace Bank.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var portfolio = new List<ITrade>
            {
                new Trade { Value = 2000000, ClientSector = "Private" },
                new Trade { Value = 400000, ClientSector = "Public" },
                new Trade { Value = 500000, ClientSector = "Public" },
                new Trade { Value = 3000000, ClientSector = "Public" },
            };

            Console.WriteLine("Input:");
            portfolio.ForEach(item => Console.WriteLine("Value = " + item.Value.ToString() + ", ClientSector = " + item.ClientSector));
            Console.WriteLine("");

            var bankTrade = new BankTrade();
            var result = bankTrade.GetTradeCategories(portfolio);
            Console.WriteLine("Output: " + string.Join(", ", result));

            var tradeCategories = new string[] { "HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK" };
            Console.WriteLine("Expected: " + string.Join(", ", tradeCategories));
            Console.ReadKey();
        }
    }
}
