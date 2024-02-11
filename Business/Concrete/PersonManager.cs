using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using ServiceReference;

namespace Business.Concrete
{
    //Çıplak Class Kalmasın.
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public IEnumerable<Person> GetList()
        {
            return Enumerable.Empty<Person>();
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
