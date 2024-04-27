using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Context;

public interface IMusicContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public Task SaveChangesAsync();
}