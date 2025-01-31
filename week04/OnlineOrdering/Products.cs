using System;

namespace OnlineOrdering
{
    class Products
    {
        private string ID { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Products(string id, string name, double price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double CalculateTotal()
        {
            return Price * Quantity;
        }
        public void GetDisplayText()
        {
            Console.WriteLine($"Product: ID-{ID}, {Name}, $ {Price}, x{Quantity}");
        }
    }
}