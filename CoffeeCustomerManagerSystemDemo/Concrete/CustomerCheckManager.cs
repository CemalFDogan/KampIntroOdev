using System;
using System.Collections.Generic;
using System.Text;
using CoffeeCustomerManagerSystemDemo.Entities;
using CoffeeCustomerManagerSystemDemo.Abstract;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace CoffeeCustomerManagerSystemDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            return true;
        }
    }
}
