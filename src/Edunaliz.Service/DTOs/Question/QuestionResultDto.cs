﻿using Edunaliz.Service.DTOs.Assigment;
using Edunaliz.Service.DTOs.Attachment;

namespace Edunaliz.Service.DTOs.Question;

public class QuestionResultDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public long? AttachmentId { get; set; }
    public AttachmentResultDto Attachment { get; set; }
    public long AssignmentId { get; set; }
    public AssignmentResultDto Assignment { get; set; }
}
