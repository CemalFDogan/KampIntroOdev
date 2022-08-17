using CoffeeCustomerManagerSystemDemo.Abstract;
using CoffeeCustomerManagerSystemDemo.Concrete;
using CoffeeCustomerManagerSystemDemo.Entities;
using System;

namespace CoffeeCustomerManagerSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 9, 26), FirstName = "Cemal Faruk", 
                LastName = "Doğan", NationalityId = "30581102572" }) ;
        }
    }
}
