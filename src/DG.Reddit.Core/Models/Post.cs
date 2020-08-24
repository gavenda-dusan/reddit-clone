using System;
using System.Collections.Generic;

namespace DG.Reddit.Core.Models
{
    public class Post
    {
        public int PostID { get; set; }

        public int SubredditID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public IList<Comment> Comments { get; set; }

        public IList<Vote> Votes { get; set; }

        public Subreddit Subreddit { get; set; }
    }
}