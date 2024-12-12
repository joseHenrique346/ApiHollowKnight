using System.Linq.Expressions;

namespace ApiHollowKnight.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        //Task<List<T>> GetAllAsync();
        //Task<T?> GetAsync(int id);
        List<T> GetAll();
        T? Get(int id);
        T Create(T entity);
        T Update(T entity);
        bool Delete(T entity);
        bool Delete(int id);
    }
}