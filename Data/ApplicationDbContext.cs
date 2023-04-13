using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proj.Models;
using System.Reflection.Emit;

namespace proj.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PostModel> Posts { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<LikeModel> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().HasMany(user => user.Posts).WithOne(post => post.User).HasForeignKey(post => post.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<CommentModel>().HasMany(c => c.Likes).WithOne(l => l.Comment).HasForeignKey(l => l.CommentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<PostModel>().HasMany(c => c.Likes).WithOne(l => l.Post).HasForeignKey(l => l.PostId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationUser>().HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.CommentAuthor).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ApplicationUser>().HasMany(u => u.Likes).WithOne(l => l.User).HasForeignKey(l => l.Username).OnDelete(DeleteBehavior.NoAction);

        }
    }
}