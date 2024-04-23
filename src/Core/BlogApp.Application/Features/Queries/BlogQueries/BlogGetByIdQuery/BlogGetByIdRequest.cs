using MediatR;

namespace BlogApp.Application.Features.Queries.BlogQueries.BlogGetByIdQuery;

public class BlogGetByIdRequest : IRequest<BlogGetByIdResponse>
{
    public int Id { get; set; }
}
