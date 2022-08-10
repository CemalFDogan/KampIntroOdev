using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Cemal Faruk";
            customer1.CustomerSurname = "DOĞAN";
            customer1.CustomerPhone = "05320554774";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Engin";
            customer2.CustomerSurname = "DEMİROĞ";
            customer2.CustomerPhone = "05381186525";
            
            Customer customer3 = new Customer();
            customer3.CustomerName = "Emre";
            customer3.CustomerSurname = "COŞKUN";
            customer3.CustomerPhone = "05068508998";


            Customer[] customers = new Customer[] {customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                do
                {
                    Console.WriteLine("------------------------------");
                } while (false);

                Console.WriteLine($"Müşterinin Adı : {customer.CustomerName} {customer.CustomerSurname}");
                Console.WriteLine($"Müşterinin Telefonu : {customer.CustomerPhone}");

                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("\n" + "------------------------CustomerManager----------------");

            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            Console.WriteLine("------------------------------");
            customerManager.Delete(customer1);
            Console.WriteLine("------------------------------");
            customerManager.Update(customer1);
            Console.WriteLine("------------------------------");
            customerManager.List(customer1);
            Console.WriteLine("------------------------------");

        }
    }
}
