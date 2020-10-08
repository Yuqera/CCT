using System.Linq;

namespace Models.SubFolder
{
    public class Accountant
    {
        public string Name { get; set; }
        public decimal Stonks { get; set; }
        public Stock[] Stocks { get; set; }

        public override string ToString()
        {
            return $"Name: { Name }\nStonks: { Stonks }\nStocks: { string.Join(", ", Stocks.Select(x => x.Name)) }";
        }
    }
}
