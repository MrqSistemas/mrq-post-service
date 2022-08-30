using PostService.Domain.Adapters;
using PostService.Domain.Adapters.Dtos;
using PostService.Domain.Business;

namespace PostService.Business.Posts
{
    public class PostBusiness : IPostBusiness
    {
        private readonly IPostAdapter _PostAdapter;

        public PostBusiness(IPostAdapter PostAdapter)
        {
            _PostAdapter = PostAdapter;
        }

        public IEnumerable<PostDto> GetList()
        {
            return _PostAdapter.GetList();
        }

        public PostDto Get(int id)
        {
            return _PostAdapter.Get(id);
        }

        public async Task<bool> Add(PostDto Post)
        {
            Post.Data_Publicacao = DateTime.UtcNow.AddHours(-3);

            return await _PostAdapter.Add(Post);
        }

        public bool Update(PostDto Post)
        {
            return _PostAdapter.Update(Post);
        }

        public bool Delete(int id)
        {
            return _PostAdapter.Delete(id);
        }
    }
}
