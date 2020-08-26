using DG.Reddit.Core.Constants;
using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public class UserConfiguration : IEntityConfiguration
    {
        public void Configuration(ModelBuilder builder)
        {
            var entity = builder.Entity<User>();

            entity.ToTable(Tables.Users, Schemas.Dbo)
                .HasKey(x => x.UserID);

            entity
                .HasMany<Post>()
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserID);

            entity
                .HasMany<Comment>()
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserID);
        }
    }
}