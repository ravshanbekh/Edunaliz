using Edunaliz.Domain.Enums;

namespace Edunaliz.Service.DTOs.User;

public class UserCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
}
