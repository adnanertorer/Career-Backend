using System.Linq.Expressions;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories;

public interface IGenericRepository<T> where T: BaseModel
{
    IQueryable<T> GetAll();
    Task<T?> GetById(object id);
    Task<T> Save(T entity);
    Task DeleteById(object id);
    T Update(T entity);
}