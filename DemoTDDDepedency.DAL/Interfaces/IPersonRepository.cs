using DemoTDDDepedency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.DAL.Interfaces
{
    public interface IPersonRepository : IBaseRepository<int,Person>
    {
        Person GetByName(string name);
    }
}
