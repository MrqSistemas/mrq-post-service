using Microsoft.AspNetCore.Mvc;
using PostService.Application.Applications;
using PostService.Domain.Adapters.Dtos;

namespace PostService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _PostApplication;

        public PostController(IPostApplication PostApplication)
        {
            _PostApplication = PostApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Posts = _PostApplication.GetList();
            return Ok(Posts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            return Ok(_PostApplication.Get(id));
        }

        [HttpPost]
        public async Task <IActionResult> Post(PostDto Post)
        {
            return Ok(await _PostApplication.Add(Post));
        }

        [HttpPut]
        public IActionResult Put(PostDto Post)
        {
            return Ok(_PostApplication.Update(Post));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_PostApplication.Delete(id));
        }
    }
}
