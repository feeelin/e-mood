namespace e_mood_dotnet;

public class Track
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Url { get; set; }
    public TimeSpan Duration { get; set; }
    public Playlist Playlist { get; set; }
}