using Bank.Library;
using Bank.Library.Enums;
using Bank.Library.Trade;
using System;
using System.Collections.Generic;
using Xunit;

namespace Bank.Test
{
    public class BankTest
    {
        [Fact]
        public void PrivateHighRiskTest()
        {
            var portfolio = new List<ITrade>
            {
                new Trade { Value = 2000000, ClientSector = "Private" }
            };

            var bankTrade = new BankTrade();
            var result = bankTrade.GetTradeCategories(portfolio);

            Assert.Equal(Risk.HIGHRISK.ToString(), result[0]);
        }

        [Fact]
        public void PublicLowRiskTest()
        {
            var portfolio = new List<ITrade>
            {
                new Trade { Value = 400000, ClientSector = "Public" }
            };

            var bankTrade = new BankTrade();
            var result = bankTrade.GetTradeCategories(portfolio);

            Assert.Equal(Risk.LOWRISK.ToString(), result[0]);
        }

        [Fact]
        public void PublicMediumRiskTest()
        {
            var portfolio = new List<ITrade>
            {
                new Trade { Value = 3000000, ClientSector = "Public" }
            };

            var bankTrade = new BankTrade();
            var result = bankTrade.GetTradeCategories(portfolio);

            Assert.Equal(Risk.MEDIUMRISK.ToString(), result[0]);
        }

        [Theory]
        [InlineData(2000000, "Private", "HIGHRISK")]
        [InlineData(400000, "Public", "LOWRISK")]
        [InlineData(500000, "Public", "LOWRISK")]
        [InlineData(3000000, "Public", "MEDIUMRISK")]
        public void PortfolioTest(double Value, string ClientSector, string risk)
        {
            var portfolio = new List<ITrade>
            {
                new Trade { Value = Value, ClientSector = ClientSector }
            };

            var bankTrade = new BankTrade();
            var result = bankTrade.GetTradeCategories(portfolio);

            Assert.Equal(risk, result[0]);
        }

    }
}
