using System.Diagnostics.CodeAnalysis;

namespace PostService.Domain.Adapters.Dtos
{
    [ExcludeFromCodeCoverage]
    public class PostDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public DateTime? Data_Publicacao { get; set; }
        public string? Area_Relevante { get; set; }
        public string? Texto { get; set; }
    }
}
