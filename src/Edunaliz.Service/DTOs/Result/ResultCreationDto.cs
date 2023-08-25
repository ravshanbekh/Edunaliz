using Edunaliz.Service.DTOs.Answer;
using Edunaliz.Service.DTOs.Question;
using Edunaliz.Service.DTOs.User;

namespace Edunaliz.Service.DTOs.Result;

public class ResultCreationDto
{
    public long UserId { get; set; }
    public long AnswerId { get; set; }
}
