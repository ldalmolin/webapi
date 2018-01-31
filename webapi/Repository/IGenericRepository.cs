using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Repository
{
public interface IGenericRepository<T> where T : class 
{
    Task<T> AddAsync(T entity);
    Task<ICollection<T>> GetAllAsync();
    Task<T> FindAsync(int id);
    void RemoveAsync(T entity);
    Task<T> UpdateAsync(T entity, object key);
    Task<T> FindAsync(Expression<Func<T, bool>> match);

    Task<int> SaveAsync();
}
}