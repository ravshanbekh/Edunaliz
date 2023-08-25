using Edunaliz.Service.DTOs.Attachment;
using Edunaliz.Service.DTOs.Category;
using Edunaliz.Service.DTOs.User;

namespace Edunaliz.Service.DTOs.Assigment;

public class AssignmentCreationDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public long UserId { get; set; }
    public long CategoryId { get; set; }
}
