using DemoTDDDepedency.DAL.Interfaces;
using DemoTDDDepedency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public Person? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public int insert(Person entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Person entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
