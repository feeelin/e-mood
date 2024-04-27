using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace e_mood_asp_net_core
{
    public class Group
    {
        [Key]  public int Id { get; set; }
        public string NameGroup { get; set; }
        public string Topic { get; set; }

        public int IdUser { get; set; }
        public User User { get; set; }

        public List<PlayList> PlayLists { get; } = new();
    }
}
