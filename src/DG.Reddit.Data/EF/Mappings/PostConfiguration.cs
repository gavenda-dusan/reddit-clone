using DG.Reddit.Core.Constants;
using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public class PostConfiguration : IEntityConfiguration
    {
        public void Configuration(ModelBuilder builder)
        {
            var entity = builder.Entity<Post>();

            entity.ToTable(Tables.Posts, Schemas.Dbo)
                .HasKey(x => x.PostID);

            entity
                .HasMany<Comment>()
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostID);

            entity
                .HasMany<Vote>()
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostID);

            entity
                .HasOne(x => x.Subreddit)
                .WithMany()
                .HasForeignKey(x => x.SubredditID);

            entity
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserID);
        }
    }
}