using System;

namespace OnlineOrdering{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few customers
            Address address1 = new Address("123 Main St", "Anytown", "TX", "12345", "US");
            Customer customer1 = new Customer("John Doe", "john@doe.com", "8305406004", address1);
            Address address2 = new Address("456 Elm St", "Anytown", "TX", "12345", "US");
            Customer customer2 = new Customer("Jane Doe", "jane@doe.com", "8305406004", address2);
            Address address3 = new Address("789 Oak St", "Edmonton", "ED", "CAH123", "CANADA");
            Customer customer3 = new Customer("Jack Doe", "jack@doe.com", "7805406004", address3);

            // Create Products
            List<Products> products1 = new List<Products>();
            products1.Add(new Products("1", "Energy Drink", 10.00, 1));
            products1.Add(new Products("2", "Apple", 6.00, 2));
            List<Products> products2 = new List<Products>();
            products2.Add(new Products("3", "Banana", 5.00, 2));
            List<Products> products3 = new List<Products>();
            products3.Add(new Products("4", "Orange", 3.00, 1));
            products3.Add(new Products("5", "Burger", 8.00, 3));
            products3.Add(new Products("6", "Fries", 4.00, 2));

            // Create Orders
            List<Order> orders = new List<Order>();
            orders.Add(new Order(customer1, products1));
            orders.Add(new Order(customer2, products2));
            orders.Add(new Order(customer3, products3));

            int count = 1;
            foreach (Order order in orders)
            {
                Console.WriteLine($"------------------------\nOrder {count}\n------------------------");
                order.GetDisplayText();
                count++;                
            }

            
            
        }


    }
}
