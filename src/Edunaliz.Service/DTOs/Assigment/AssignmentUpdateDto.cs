using Edunaliz.Service.DTOs.Attachment;
using Edunaliz.Service.DTOs.Category;
using Edunaliz.Service.DTOs.User;

namespace Edunaliz.Service.DTOs.Assigment;

public class AssignmentUpdateDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public long? AttachmentId { get; set; }
    public AttachmentResultDto Attachment { get; set; }
    public TimeSpan Duration { get; set; }
    public long UserId { get; set; }
    public UserResultDto User { get; set; }
    public long CategoryId { get; set; }
    public CategoryResultDto Category { get; set; }
}
