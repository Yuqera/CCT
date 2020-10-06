using MainProject;
using Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MainProjectTests
{
    [TestFixture]
    public class StockMarketTests
    {
        private StockMarket stockMarket;

        [Test]
        public void GetStocks()
        {
            // Arrange
            stockMarket = new StockMarket();
            Stock stockTest1 = new Stock(1, "Test", 1);
            Stock stockTest2 = new Stock(2, "Test", 2);
            Stock stockTest3 = new Stock(3, "Test", 3);
            stockMarket.AddStock(stockTest1);
            stockMarket.AddStock(stockTest2);
            stockMarket.AddStock(stockTest3);

            List<Stock> expected = new List<Stock>()
            {
                stockTest1,
                stockTest2,
                stockTest3
            };

            // Act
            List<Stock> actual = stockMarket.GetStocks();

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void AddStock()
        {
            // Arrange
            stockMarket = new StockMarket();

            Stock newStock = new Stock(1, "MyNewStock", 100);
            List<Stock> stockMarketOutcome = new List<Stock>
            {
                newStock
            };

            // Act
            stockMarket.AddStock(newStock);

            // Assert
            Assert.AreEqual(stockMarket.GetStocks(), stockMarketOutcome);
        }

        [Test]
        public void RemoveStock()
        {
            // Arrange
            stockMarket = new StockMarket();
            PrepareMockDataToStockMarket();

            // Act
            List<Stock> stocks = stockMarket.GetStocks();
            Stock google = stocks[0];
            Stock myExpensiveStocks = stocks[1];
            stockMarket.RemoveStock(google);

            // Assert
            Assert.AreEqual(stockMarket.GetStocks()[0], myExpensiveStocks);
        }

        private void PrepareMockDataToStockMarket()
        {
            Stock google = new Stock(1, "Google", 10000000000);
            Stock myExpensiveStocks = new Stock(2, "MES", 10);
            stockMarket.AddStock(google);
            stockMarket.AddStock(myExpensiveStocks);
        }
    }
}
