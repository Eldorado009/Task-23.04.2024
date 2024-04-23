using BlogApp.Domain.Entities;
using BlogApp.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    DbSet<Blog> blogs {  get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
