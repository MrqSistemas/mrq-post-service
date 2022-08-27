using System.Diagnostics.CodeAnalysis;

namespace YourProjectName.Domain.Entities.Users
{
    [ExcludeFromCodeCoverage]
    public class User : EntityBase
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
