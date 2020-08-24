using DG.Reddit.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DG.Reddit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostAppService _postAppService;

        public PostController(PostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        [HttpGet]
        public void GetPosts()
        {
            _postAppService.GetPosts();
        }
    }
}