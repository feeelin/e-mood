using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace e_mood_asp_net_core
{
    public class Track
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Executor { get; set; }

        public int IdPlayList { get; set; }
        public PlayList PlayList { get; set; }
    }
}
