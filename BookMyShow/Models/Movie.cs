using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int DirectorId { get; set; }
        [Required]
        public Director? Director { get; set; }
        [Required]
        public List<Actor>? Actors { get; set; }
        public Genre? Genre { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
