using DemoTDDDepedency.BLL.Interfaces;
using DemoTDDDepedency.DAL.Interfaces;
using DemoTDDDepedency.DAL.Repositories;
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
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person? GetById(int id)
        {
            return _personRepository.GetById(id);
        }

        public Person? GetByName(string name)
        {
            return _personRepository.GetByName(name);
        }

        public IEnumerable<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public int insert(Person person)
        {
            throw new NotImplementedException();
        }

        public int update(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
