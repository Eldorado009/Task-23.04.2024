using AutoMapper;
using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities;
using MediatR;

namespace BlogApp.Application.Features.Commands.BlogCommands;

public class BlogPostHandler : IRequestHandler<BlogPostRequest, BlogPostResponse>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public BlogPostHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<BlogPostResponse> Handle(BlogPostRequest request, CancellationToken cancellationToken)
    {
        Blog blog = _mapper.Map<Blog>(request);
        await _blogRepository.InsertAsync(blog);
        await _blogRepository.CommitAsync();

        return _mapper.Map<BlogPostResponse>(blog);
    }
}
