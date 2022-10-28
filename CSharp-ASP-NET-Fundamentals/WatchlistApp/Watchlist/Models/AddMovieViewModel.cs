using System.ComponentModel.DataAnnotations;
using Watchlist.Data.Models;
using static Watchlist.Data.DataConstants.Movie;

namespace Watchlist.Models
{
    public class AddMovieViewModel
    {       
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

        public int GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();
    }
}
