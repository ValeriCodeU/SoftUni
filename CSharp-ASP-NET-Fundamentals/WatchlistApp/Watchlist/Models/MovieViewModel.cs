using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.DataConstants.Movie;

namespace Watchlist.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxMovieTitle)]
        [MinLength(MinMovieTitle)]

        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxDirectorName)]
        [MinLength(MinDirectorName)]

        public string Director { get; set; } = null!;

        [Required]

        public string ImageUrl { get; set; } = null!;

        [Range(typeof(decimal), "0.00", "10.00", ConvertValueInInvariantCulture = true)]

        public decimal Rating { get; set; }

        public string Genre { get; set; } = null!;
    }
}
