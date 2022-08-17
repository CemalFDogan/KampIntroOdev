using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReference1.KPSPublicSoapClient;

namespace GamerManagerSystem.Adapters1
{
    public class MernisServiceAdapter1 : IPersonCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
