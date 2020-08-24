using DG.Reddit.Core.Constants;
using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public class SubredditConfiguration : IEntityConfiguration
    {
        public void Configuration(ModelBuilder builder)
        {
            var entity = builder.Entity<Subreddit>();

            entity.ToTable(Tables.Subreddits, Schemas.Dbo)
                .HasKey(x => x.SubredditID);

            entity
                .HasMany<Post>()
                .WithOne(x => x.Subreddit)
                .HasForeignKey(x => x.SubredditID);
        }
    }
}