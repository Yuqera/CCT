using System.Collections.Generic;

namespace MainProject
{
    public class StockMarket
    {
        private readonly List<Models.Stock> stocks;

        public StockMarket()
        {
            stocks = new List<Models.Stock>();
        }

        public List<Models.Stock> GetStocks()
        {
            return stocks;
        }

        public void AddStock(Models.Stock stock)
        {
            stocks.Add(stock);
        }

        public void RemoveStock(Models.Stock stock)
        {
            stocks.Remove(stock);
        }
    }
}
