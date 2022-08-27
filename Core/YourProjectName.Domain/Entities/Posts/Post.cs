using System.Diagnostics.CodeAnalysis;

namespace PostService.Domain.Entities.Posts
{
    [ExcludeFromCodeCoverage]
    public class Post : EntityBase
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public DateTime? Data_Publicacao { get; set; }
        public string? Area_Relevante { get; set; }
        public string? Texto { get; set; }
    }
}
