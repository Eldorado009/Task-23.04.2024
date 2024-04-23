namespace BlogApp.Application.Features.Queries.BlogQueries.BlogGetByIdQuery;

public class BlogGetByIdResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}
