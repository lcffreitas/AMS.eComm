namespace AMS.eComm.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        Task Add(T Entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id); 
        void Update(T entity);
    }
}