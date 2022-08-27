using AutoMapper;
using PostService.Domain.Adapters;
using PostService.Domain.Adapters.Dtos;
using PostService.Domain.Entities.Posts;
using PostService.Repository.Context;
using System.Globalization;

namespace PostService.Repository.Posts
{
    public class PostRepositorySqlServer : IPostAdapter
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public PostRepositorySqlServer(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public IEnumerable<PostDto> GetList()
        {
            var Posts = _appDbContext.Posts;

            var PostDtos = _mapper.Map<List<PostDto>>(Posts);

            return PostDtos;
        }

        public PostDto Get(int id)
        {
            var Posts = _appDbContext.Posts;

            var getPost = Posts.Where(p => p.Id == id).FirstOrDefault();

            return _mapper.Map<PostDto>(getPost);
        }

        public async Task <bool> Add(PostDto Post)
        {
            Post addPost = _mapper.Map<Post>(Post);

            addPost.Data_Publicacao = DateTime.Now;

            await _appDbContext.Set<Post>().AddAsync(addPost);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Update(PostDto Post)
        {
            Post updatePost = _mapper.Map<Post>(Post);

            updatePost.Data_Publicacao = DateTime.Now;

            _appDbContext.Set<Post>().Update(updatePost);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var Post = _appDbContext.Posts;

            Post deletePost = Post.Where(p => p.Id == id).FirstOrDefault();

            _appDbContext.Remove(deletePost);

            _appDbContext.SaveChanges();

            return true;
        }

    }
}
