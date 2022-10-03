using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    public class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
}
