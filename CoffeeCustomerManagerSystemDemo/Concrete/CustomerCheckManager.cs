using System;
using System.Collections.Generic;
using System.Text;
using CoffeeCustomerManagerSystemDemo.Entities;
using CoffeeCustomerManagerSystemDemo.Abstract;

namespace CoffeeCustomerManagerSystemDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
