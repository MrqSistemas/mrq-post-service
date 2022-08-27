using System.Diagnostics.CodeAnalysis;

namespace YourProjectName.Domain.Adapters.Dtos
{
    [ExcludeFromCodeCoverage]
    public class UserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
