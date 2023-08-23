namespace Edunaliz.Domain.Entities
{
    public class Assignment : Auditable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public TimeSpan Duration { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
