using Microsoft.EntityFrameworkCore;

namespace e_mood_asp_net_core
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
        : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<PlayList> PlayLists => Set<PlayList>();
        public DbSet<Track> Tracks => Set<Track>();
    }
}
