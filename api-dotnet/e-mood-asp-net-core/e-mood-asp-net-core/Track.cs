using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_mood_asp_net_core
{
    public class Track
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Executor { get; set; }

        public int IdPlayList { get; set; }
        public PlayList PlayList { get; set; }
    }
}
