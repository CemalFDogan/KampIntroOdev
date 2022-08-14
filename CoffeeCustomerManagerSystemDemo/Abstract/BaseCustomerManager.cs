using CoffeeCustomerManagerSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManagerSystemDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"Saved to db : {customer.FirstName} {customer.LastName}");
        }        
    }
}
