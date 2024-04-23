using BlogApp.Application.Features.Commands.BlogCommands;
using BlogApp.Application.Features.Queries.BlogQueries.BlogGetByIdQuery;
using BlogApp.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("")]
        public async Task<IActionResult> Post (BlogPostRequest request)
        {
            
            return Ok(await _mediator.Send(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get (int id) 
        {
            BlogGetByIdRequest request = new BlogGetByIdRequest { Id = id};
            return Ok(await _mediator.Send(request));
        }
    }
}
