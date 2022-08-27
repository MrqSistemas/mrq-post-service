using PostService.Domain.Adapters.Dtos;
using PostService.Domain.Business;

namespace PostService.Application.Applications
{
    public class PostApplication : IPostApplication
    {
        private readonly IPostBusiness _PostBusiness;

        public PostApplication(IPostBusiness PostBusiness)
        {
            _PostBusiness = PostBusiness;
        }

        public IEnumerable<PostDto> GetList()
        {
            return _PostBusiness.GetList();
        }

        public PostDto Get(int id)
        {
            return _PostBusiness.Get(id);
        }

        public Task<bool> Add(PostDto Post)
        {
            return _PostBusiness.Add(Post);
        }

        public bool Update(PostDto Post)
        {
            return _PostBusiness.Update(Post);
        }

        public bool Delete(int id)
        {
            return _PostBusiness.Delete(id);
        }
    }
}
