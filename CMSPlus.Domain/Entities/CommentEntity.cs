namespace CMSPlus.Domain.Entities;

public class CommentEntity : BaseEntity
{
    public int TopicId { get; set; } 
    public virtual TopicEntity Topic { get; set; } 
    public string FullName { get; set; } = null!;
    public string Comment { get; set; } = null!;
}
