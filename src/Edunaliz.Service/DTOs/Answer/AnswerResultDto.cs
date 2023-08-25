using Edunaliz.Service.DTOs.Attachment;
using Edunaliz.Service.DTOs.Question;

namespace Edunaliz.Service.DTOs.Answer;

public class AnswerResultDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public bool IsTrue { get; set; }
    public long? AttachmentId { get; set; }
    public AttachmentResultDto Attachment { get; set; }
    public long QuestionId { get; set; }
    public QuestionResultDto Question { get; set; }
}
