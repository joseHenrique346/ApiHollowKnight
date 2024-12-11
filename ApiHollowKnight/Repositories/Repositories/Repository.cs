using ApiHollowKnight.Models;
using ApiHollowKnight.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiHollowKnight.Repositories.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return [.. _dbSet];
        }

        public T? Get(int id)
        {
            return _dbSet.Find(id);
        }
        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            //_context.SaveChanges();
            return entity;
        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            //_context.SaveChanges();
            return entity;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            //_context.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            _dbSet.Remove(new T { Id = id });
            //_context.SaveChanges();
            return true;
        }
    }
}
