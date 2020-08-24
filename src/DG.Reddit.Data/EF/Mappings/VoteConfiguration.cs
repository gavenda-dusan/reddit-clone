using DG.Reddit.Core.Constants;
using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public class VoteConfiguration : IEntityConfiguration
    {
        public void Configuration(ModelBuilder builder)
        {
            var entity = builder.Entity<Vote>();

            entity.ToTable(Tables.Votes, Schemas.Dbo)
                .HasKey(x => x.VoteID);

            entity
                .HasOne(x => x.Post)
                .WithMany()
                .HasForeignKey(x => x.PostID);

            entity
                .HasOne(x => x.Comment)
                .WithMany()
                .HasForeignKey(x => x.CommentID);
        }
    }
}