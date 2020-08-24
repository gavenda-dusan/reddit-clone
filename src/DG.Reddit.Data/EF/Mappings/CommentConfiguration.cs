using DG.Reddit.Core.Constants;
using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public class CommentConfiguration : IEntityConfiguration
    {
        public void Configuration(ModelBuilder builder)
        {
            var entity = builder.Entity<Comment>();

            entity.ToTable(Tables.Comments, Schemas.Dbo)
                .HasKey(x => x.CommentID);

            entity
                .HasOne(x => x.Post)
                .WithMany()
                .HasForeignKey(x => x.PostID);

            entity
                .HasMany<Vote>()
                .WithOne(x => x.Comment)
                .HasForeignKey(x => x.CommentID);
        }
    }
}