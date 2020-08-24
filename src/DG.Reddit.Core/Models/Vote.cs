using System;

namespace DG.Reddit.Core.Models
{
    public class Vote
    {
        public int VoteID { get; set; }

        public int? PostID { get; set; }

        public int? CommentID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string VoteType { get; set; }

        public Post Post { get; set; }

        public Comment Comment { get; set; }
    }
}