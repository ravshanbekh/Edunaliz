using Edunaliz.Service.DTOs.Answer;
using Edunaliz.Service.DTOs.Question;
using Edunaliz.Service.DTOs.User;

namespace Edunaliz.Service.DTOs.Result;

public class ResultCreationDto
{
    public long QuestionId { get; set; }
    public QuestionResultDto Question { get; set; }
    public long UserId { get; set; }
    public UserResultDto User { get; set; }
    public long AnswerId { get; set; }
    public AnswerResultDto Answer { get; set; }
}
