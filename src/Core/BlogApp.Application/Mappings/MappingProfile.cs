using AutoMapper;
using BlogApp.Application.Features.Commands.BlogCommands;
using BlogApp.Application.Features.Queries.BlogQueries.BlogGetByIdQuery;
using BlogApp.Domain.Entities;

namespace BlogApp.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Blog, BlogPostResponse>().ReverseMap();
        CreateMap<Blog, BlogPostRequest>().ReverseMap();
        CreateMap<Blog, BlogGetByIdResponse>().ReverseMap();
    }
}
