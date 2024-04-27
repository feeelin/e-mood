namespace e_mood_dotnet;

public class Playlist
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid OwnerId { get; set; }
    public List<User> Subscribers { get; set; }
    public string CoverUrl { get; set; }
}