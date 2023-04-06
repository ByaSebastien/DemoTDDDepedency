using DemoTDDDepedency.BLL.Interfaces;
using DemoTDDDepedency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.BLL.Services
{
    public class PersonService : IPersonService
    {
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int insert(Person person)
        {
            throw new NotImplementedException();
        }

        public int update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
