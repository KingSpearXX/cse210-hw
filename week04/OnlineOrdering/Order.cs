using System;

namespace OnlineOrdering
{
    class Order
    {
        private Customer _Customer { get; set; }
        private List<Products> _Products { get; set; }
       
        public Order(Customer customer, List<Products> products)
        {
            _Customer = customer;
            _Products = products;
        }
        private double CalculateTotal()
        {
            double total = 0;
            foreach (Products product in _Products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }
        private double CalculateShipping()
        {
            if (_Customer.USA())
            {
                return 5.00;
            }
            else
            {
                return 35.00;
            }
        }
        public void GetDisplayText()
        {
            Console.WriteLine("Shipping Label:");
            _Customer.GetDisplayText();
            Console.WriteLine("\nPacking Label:");
            foreach (Products product in _Products)
            {
                product.GetDisplayText();
            }
            Console.WriteLine("\nTotal:");
            Console.WriteLine($"Amount Due: $ {CalculateTotal()} Shipping: $ {CalculateShipping()}");
            Console.WriteLine($"Grand Total: $ {CalculateTotal() + CalculateShipping()}");

        }
        
    }
}