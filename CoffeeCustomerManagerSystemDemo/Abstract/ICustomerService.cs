using CoffeeCustomerManagerSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManagerSystemDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
