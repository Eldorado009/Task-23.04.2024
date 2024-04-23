using MediatR;
using System.Net;

namespace BlogApp.Application.Features.Commands.BlogCommands;

public class BlogPostRequest: IRequest<BlogPostResponse>
{
    public string Title { get; set; }
    public string Description { get; set; }
}
