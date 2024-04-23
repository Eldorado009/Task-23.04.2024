namespace BlogApp.Domain.Entities.Common;

public interface IBaseAuditable
{
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public string? ModifiedBy { get; set; }
}
