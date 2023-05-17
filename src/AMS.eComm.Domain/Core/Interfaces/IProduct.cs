namespace AMS.eComm.Domain.Core.Interfaces
{
    public interface IProduct : IRepository<Entities.Product>
    {
        void Delete(Guid id);
    }
}