using PostService.Domain.Adapters.Dtos;

namespace PostService.Application.Applications
{
    public interface IPostApplication
    {
        public IEnumerable<PostDto> GetList();
        public PostDto Get(int id);
        public Task<bool> Add(PostDto Post);
        public bool Update(PostDto Post);
        public bool Delete(int id);
    }
}
