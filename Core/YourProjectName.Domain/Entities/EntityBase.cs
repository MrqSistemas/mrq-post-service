using System.Diagnostics.CodeAnalysis;

namespace YourProjectName.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
