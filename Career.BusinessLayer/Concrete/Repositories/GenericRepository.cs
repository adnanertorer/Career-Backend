using Career.BusinessLayer.Abstracts.Repositories;
using Career.Core;
using Career.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Career.BusinessLayer.Concrete.Repositories;

public class GenericRepository<T>:IGenericRepository<T> where T: BaseModel
{
    protected readonly CareerDbContext DbContext;
    private readonly DbSet<T> _dbSet;

    protected GenericRepository(CareerDbContext dbContext)
    {
        DbContext = dbContext;
        _dbSet = DbContext.Set<T>();
    }

    public IQueryable<T> GetAll()
    {
        return _dbSet.AsQueryable();
    }

    public async Task<T?> GetById(object id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> Save(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task DeleteById(object id)
    {
        var entity = await _dbSet.FindAsync(id);
        _dbSet.Remove(entity!);
    }

    public T Update(T entity)
    {
        _dbSet.Attach(entity);
        DbContext.Entry(entity).State = EntityState.Modified;
        return entity;
    }
}