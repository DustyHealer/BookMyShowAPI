using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Review
    {
        public int ID { get; set; }
        [StringLength(255)]
        public string? Text { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public Movie? Movie { get; set; }
    }
}
