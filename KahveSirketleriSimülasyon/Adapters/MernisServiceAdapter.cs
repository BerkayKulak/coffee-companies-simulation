using KahveSirketleriSimülasyon.Abstract;
using KahveSirketleriSimülasyon.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace KahveSirketleriSimülasyon.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient
                (MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new MernisServiceReference.TCKimlikNoDogrulaRequest
                (new MernisServiceReference.TCKimlikNoDogrulaRequestBody
                (Convert.ToInt64(customer.NatioanlityId), customer.FirstName.ToUpper(), 
                customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
