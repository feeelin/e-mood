using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_mood_asp_net_core
{
    public class PlayList
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public int IdGroup { get; set; }

        public List<Track> Tarcks { get; } = new();
    }
}
