using Attributes;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        // Attributes'lar ile birlikte merkezi bir noktada iş kuralları koyabiliriz.
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1, LastName="Demiroğ", Age=32};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
}
