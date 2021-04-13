using Microsoft.EntityFrameworkCore;

namespace Baseline.Models
{
    public class Assignment2DataContext : DbContext
    {

        public Assignment2DataContext(DbContextOptions<Assignment2DataContext> options) : base(options)
        {
        }

        public DbSet<BadWord> BadWords
        {
            get;
            set;
        }
        public DbSet<Photo> Photos
        {
            get;
            set;
        }

        public DbSet<User> Users
        {
            get;
            set;
        }

        public DbSet<Role> Roles
        {
            get;
            set;
        }

        public DbSet<BlogPost> BlogPosts
        {
            get;
            set;
        }

        public DbSet<Comment> Comments
        {
            get;
            set;
        }

    }
}
