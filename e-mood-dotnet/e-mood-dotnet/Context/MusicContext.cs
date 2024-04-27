using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Context;

public class MusicContext : DbContext, IMusicContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public Task SaveChangesAsync() => SaveChangesAsync(default);

    public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User")
            .Property(p => p.Id).HasDefaultValue(Guid.NewGuid());
        modelBuilder.Entity<Playlist>().ToTable("Playlist")
            .Property(p => p.Id).HasDefaultValue(Guid.NewGuid());
        modelBuilder.Entity<Track>().ToTable("Track")
            .Property(p => p.Id).HasDefaultValue(Guid.NewGuid());
    }

}