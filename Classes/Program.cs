using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            Console.WriteLine();
            ProductManager productManager = new ProductManager();
            productManager.Add();

            Console.WriteLine("--------------------");

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Cemal Faruk";
            customer1.LastName = "Doğan";
            customer1.City = "Malatya";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ramazan",
                LastName = "Doğan",
                City = "Malatya"
            };
            Console.WriteLine(customer1.FirstName);
        }
    }
}
