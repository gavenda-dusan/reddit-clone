using DG.Reddit.Core.Repositories;
using DG.Reddit.Data.EF;

namespace DG.Reddit.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly DataContext _dataContext;

        public PostRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void GetPosts()
        {
            var test = _dataContext.ContextId;
        }
    }
}