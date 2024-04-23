using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities;
using BlogApp.Persistence.Context;

namespace BlogApp.Persistence.RepositoryImplementations;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(AppDbContext context) : base(context)
    {

    }
}
