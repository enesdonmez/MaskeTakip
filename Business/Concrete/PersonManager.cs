using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        // Encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return new List<Person>();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            TCKimlikNoDogrulaRequest request = new TCKimlikNoDogrulaRequest();
            TCKimlikNoDogrulaRequestBody body = new TCKimlikNoDogrulaRequestBody();
            body.TCKimlikNo = person.NationalIdentity;
            body.Ad = person.FirstName;
            body.Soyad = person.LastName;
            body.DogumYili = person.DayOfBirthYear;
            request.Body = body;

            return client.TCKimlikNoDogrulaAsync(request).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
