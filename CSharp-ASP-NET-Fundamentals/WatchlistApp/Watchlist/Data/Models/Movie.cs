using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Watchlist.Data.DataConstants.Movie;

namespace Watchlist.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxMovieTitle)]

        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxDirectorName)]

        public string Director { get; set; } = null!;

        [Required]

        public string ImageUrl { get; set; } = null!;

        [Column(TypeName = "decimal(5, 2)")]

        public decimal Rating { get; set; }

        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]

        public Genre Genre { get; set; }

        public ICollection<UserMovie> UsersMovies { get; set; } = new List<UserMovie>();
    }
}
