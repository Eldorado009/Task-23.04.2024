using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities.Common;
using BlogApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace BlogApp.Persistence.RepositoryImplementations;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    private readonly AppDbContext _context;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }


    public DbSet<TEntity> Table => _context.Set<TEntity>();


    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Delete(TEntity entity)
    {
        Table.Remove(entity);
    }

    public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[]? includes)
    {
        return await Table.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await Table.FindAsync(id);
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>>? expression = null, params string[]? includes)
    {
        return await Table.FirstOrDefaultAsync(expression);
    }

    public async Task InsertAsync(TEntity entity)
    {
         await Table.AddAsync(entity);
    }
}
