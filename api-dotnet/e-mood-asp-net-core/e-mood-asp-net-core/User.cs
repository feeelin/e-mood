using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_mood_asp_net_core
{
    public class User
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }
        public int MainGroup { get; set; }
    }
}
