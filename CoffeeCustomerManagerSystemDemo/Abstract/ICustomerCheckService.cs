using CoffeeCustomerManagerSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManagerSystemDemo
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
