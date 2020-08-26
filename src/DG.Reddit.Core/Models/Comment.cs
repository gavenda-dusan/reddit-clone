using System;
using System.Collections.Generic;

namespace DG.Reddit.Core.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        public int PostID { get; set; }

        public int UserID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string Content { get; set; }

        public Post Post { get; set; }

        public User User { get; set; }

        public IList<Vote> Votes { get; set; }
    }
}