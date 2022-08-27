using AutoMapper;
using PostService.Domain.Adapters.Dtos;
using PostService.Domain.Entities.Posts;

namespace PostService.Repository.Posts.Mappers
{
    public class PostMapper : Profile
    {
        public PostMapper()
        {
            CreateMap<Post, PostDto>()
                .ReverseMap();
        }
    }
}
