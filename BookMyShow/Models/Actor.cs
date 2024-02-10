using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Actor
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
