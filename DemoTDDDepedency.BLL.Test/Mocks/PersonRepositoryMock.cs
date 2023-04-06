using DemoTDDDepedency.DAL.Interfaces;
using DemoTDDDepedency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.BLL.Test.Mocks
{
    public class PersonRepositoryMock : IPersonRepository
    {
        private List<Person> _data = new List<Person>()
        {
            new Person()
            {
                Id = 1,
                FirstName = "Bulbizare",
                LastName = "La feuille"
            },
            new Person()
            {
                Id = 2,
                FirstName = "Ratata",
                LastName = "Dis n'importe quoi"
            },
            new Person()
            {
                Id = 3,
                FirstName = "Mr Mime",
                LastName = "De la famille marceau"
            },
            new Person()
            {
                Id = 4,
                FirstName = "Mew",
                LastName = "L'originel"
            }
        };
        private int _nextId = 5;
        public Person? GetById(int id)
        {
            return _data.FirstOrDefault(p => p.Id == id);
        }

        public Person? GetByName(string name)
        {
            return _data.FirstOrDefault(p => p.FirstName == name || p.LastName == name);
        }

        public IEnumerable<Person> GetAll()
        {
            return _data;
        }

        public int insert(Person entity)
        {
            Person data = new Person()
            {
                Id = _nextId++,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
            };
            
            _data.Add(data);

            return data.Id;
        }

        public bool Update(int id, Person entity)
        {
            Person? data = GetById(id);

            if(data is null)
                return false;

            data.FirstName = entity.FirstName;
            data.LastName = entity.LastName;

            return true;
        }
        public bool Delete(int id)
        {
            Person? data = GetById(id);

            if (data is null)
                return false;

            _data.Remove(data);

            return true;
        }
    }
}
