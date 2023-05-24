using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Services;

namespace AMS.eComm.Services.Service
{
    public class ProductService : IBaseService<Product>
    {
        private readonly IRepository<Product> _repository;
        public ProductService (IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Add(Product entity)
        {
            await _repository.Add(entity);
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}