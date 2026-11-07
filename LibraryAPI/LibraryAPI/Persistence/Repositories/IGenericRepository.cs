using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Persistence.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetAll();

        T? GetById(Guid id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
