namespace Edunaliz.Service.DTOs.Category;

public class CategoryResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long? ParentId { get; set; }
}
