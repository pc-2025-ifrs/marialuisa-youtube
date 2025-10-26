using Microsoft.EntityFrameworkCore;
using trab1.Model;

namespace trab1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}