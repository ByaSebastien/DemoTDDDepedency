using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDDepedency.DAL.Interfaces
{
    public interface IBaseRepository<TKey,TEntity>
    {
        TEntity? GetById(TKey id);
        IEnumerable<TEntity> GetAll();
        TKey insert(TEntity entity);
        bool Update(TKey id,TEntity entity);
        bool Delete(TKey id);
    }
}
