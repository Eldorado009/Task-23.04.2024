using BlogApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogApp.Application.Repositories;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    DbSet<TEntity> Table { get; }
    Task InsertAsync(TEntity entity);
    void Delete (TEntity entity);
    Task<TEntity> GetByIdAsync (int id);
    Task<ICollection<TEntity>> GetAllAsync (Expression<Func<TEntity,bool>> expression = null, params string[]? includes);
    Task<TEntity> GetSingleAsync (Expression<Func<TEntity,bool>> expression = null, params string[]? includes);
    Task CommitAsync();
}
