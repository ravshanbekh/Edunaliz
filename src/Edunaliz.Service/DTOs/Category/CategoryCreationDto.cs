namespace Edunaliz.Service.DTOs.Category;

public class CategoryCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long? ParentId { get; set; }
}
