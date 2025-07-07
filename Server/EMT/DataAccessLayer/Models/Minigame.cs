using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Minigame
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string>? Tags { get; set; } 

        public string? Description { get; set; }
    }
}
