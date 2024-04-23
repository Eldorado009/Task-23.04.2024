using BlogApp.Domain.Entities.Common;

namespace BlogApp.Domain.Entities;

public class Blog : BaseEntity, IBaseAuditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public string? ModifiedBy { get; set; }
}
