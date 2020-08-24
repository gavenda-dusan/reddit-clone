using DG.Reddit.Core.Repositories;

namespace DG.Reddit.Application.Services
{
    public class PostAppService
    {
        private readonly IPostRepository _postRepository;

        public PostAppService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void GetPosts()
        {
            _postRepository.GetPosts();
        }
    }
}