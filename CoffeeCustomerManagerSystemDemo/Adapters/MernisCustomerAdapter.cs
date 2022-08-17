using CoffeeCustomerManagerSystemDemo.Abstract;
using CoffeeCustomerManagerSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace CoffeeCustomerManagerSystemDemo.Adapters
{
    public class MernisCustomerAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), 
                customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
