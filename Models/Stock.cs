namespace Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }

        public Stock(int id, string name, decimal value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
