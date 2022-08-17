﻿using CoffeeCustomerManagerSystemDemo.Entities;
using CoffeeCustomerManagerSystemDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManagerSystemDemo.Abstract
{
    public interface ICustomerCheckService
    {
        void CheckIfRealPerson(Customer customer)
    }
}
