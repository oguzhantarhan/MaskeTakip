using Business.Abstract;
using Entities.Concrete;
using MernisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {



            return null;
        }
        public bool CheckPerson(Person person)
        {
            
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalId,person.FistName,person.LastName,person.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
