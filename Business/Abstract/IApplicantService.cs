using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        public void ApplyForMask(Person person);
        public IEnumerable<Person> GetList();
        public bool CheckPerson(Person person);
    }
}
