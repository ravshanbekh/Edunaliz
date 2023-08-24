using System.Net.Mail;

namespace Edunaliz.Service.DTOs.Answer;

public class AnswerUpdateDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public bool IsTrue { get; set; }
    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
    public long QuestionId { get; set; }
    public QuestionResultDto Question { get; set; }
}
