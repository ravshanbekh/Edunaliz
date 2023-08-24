using Edunaliz.Domain.Commons;

namespace Edunaliz.Domain.Entities;

public class Attachment : Auditable
{
    public string FilePath { get; set; }
    public string FileName { get; set; }
}
