using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace e_mood_asp_net_core
{
    public class User
    {
        [Key]  public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }
        public int MainGroup { get; set; }

        public List<Group> Groups { get; } = new();
    }
}
