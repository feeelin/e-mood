using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace e_mood_asp_net_core
{
    public class PlayList
    {

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public int IdGroup { get; set; }
        public Group Group { get; set; }

        public List<Track> Tarcks { get; } = new();
    }
}
