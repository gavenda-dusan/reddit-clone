using System.Collections.Generic;

namespace DG.Reddit.Core.Models
{
    public class Subreddit
    {
        public int SubredditID { get; set; }

        public string Name { get; set; }

        public IList<Post> Posts { get; set; }
    }
}