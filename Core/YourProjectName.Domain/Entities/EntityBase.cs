using System.Diagnostics.CodeAnalysis;

namespace PostService.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
