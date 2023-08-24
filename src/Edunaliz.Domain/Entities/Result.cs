using Edunaliz.Domain.Commons;

namespace Edunaliz.Domain.Entities;

public class Result : Auditable
{
    public long QuestionId { get; set; }
    public Question Question { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public long AnswerId { get; set; }
    public Answer Answer { get; set; }
}
