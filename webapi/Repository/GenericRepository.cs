using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Repository
{
public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly WebapiContext _context;

    public GenericRepository(WebapiContext webapiContext)
    {
        _context = webapiContext;
    }

    public async virtual Task<T> AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);  
        await _context.SaveChangesAsync();  
        return entity; 
    }

    public async virtual Task<ICollection<T>> GetAllAsync()  
    {  
       return await _context.Set<T>().ToListAsync();  
    }

    public async virtual Task<T> FindAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);   
    }

    public async virtual void RemoveAsync(T entity)
    {
        _context.Set<T>().Remove(entity);  
        await _context.SaveChangesAsync();
    }

    public async virtual Task<T> UpdateAsync(T entity, object key)
    {
        if (entity == null)  
        return null;  
        T exist =await  _context.Set<T>().FindAsync(key);  
        if (exist != null)  
        {  
            _context.Entry(exist).CurrentValues.SetValues(entity);  
            await _context.SaveChangesAsync();  
        }  
        return exist;
    }

    public async virtual Task<T> FindAsync(Expression<Func<T, bool>> match)
    {
         return await _context.Set<T>().SingleOrDefaultAsync(match);  
    }

    public async virtual Task<int> SaveAsync()  
    {  
      return await _context.SaveChangesAsync();  
    }  
}
}