using DG.Reddit.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Subreddit> Subreddits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subreddit>()
                .HasData(
                new Subreddit()
                {
                    SubredditID = 1,
                    Name = "Test Sub"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}