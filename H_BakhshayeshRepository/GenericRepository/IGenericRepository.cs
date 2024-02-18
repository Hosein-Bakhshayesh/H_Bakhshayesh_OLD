using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_BakhshayeshRepository.GenericRepository
{
    public interface IGenericRepository<T>:IDisposable
    {
        List<T> GetAll();
        T GetEntity(Guid id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(Guid id);
        void Save();
    }
}
