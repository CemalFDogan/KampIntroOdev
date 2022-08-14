using System;
using System.Collections.Generic;
using System.Text;
using CoffeeCustomerManagerSystemDemo.Abstract;
using CoffeeCustomerManagerSystemDemo.Entities;
using MernisServiceReference;

namespace CoffeeCustomerManagerSystemDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), 
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
        }
    }
}
