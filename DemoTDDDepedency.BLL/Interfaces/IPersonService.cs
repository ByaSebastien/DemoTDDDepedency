using DemoTDDDepedency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.BLL.Interfaces
{
    public interface IPersonService
    {
        Person? GetById(int id);
        Person? GetByName(string name);
        IEnumerable<Person> GetAll();
        int insert(Person person);
        int update(int id, Person person);
        int delete(int id);
    }
}
