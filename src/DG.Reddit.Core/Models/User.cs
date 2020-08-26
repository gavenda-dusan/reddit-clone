using System.Collections.Generic;

namespace DG.Reddit.Core.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Post> Posts { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}