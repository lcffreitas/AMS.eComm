using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task Add();
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id); 
    }
}