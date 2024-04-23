using AutoMapper;
using BlogApp.Application.Repositories;
using BlogApp.Domain.Entities;
using MediatR;

namespace BlogApp.Application.Features.Queries.BlogQueries.BlogGetByIdQuery;

public class BlogGetByIdHandler : IRequestHandler<BlogGetByIdRequest, BlogGetByIdResponse>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public BlogGetByIdHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<BlogGetByIdResponse> Handle(BlogGetByIdRequest request, CancellationToken cancellationToken)
    {
        Blog blog = await _blogRepository.GetByIdAsync(request.Id);
        return _mapper.Map<BlogGetByIdResponse>(blog);
    }
}
