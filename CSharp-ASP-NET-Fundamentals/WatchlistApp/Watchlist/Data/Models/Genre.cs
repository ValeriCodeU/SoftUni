using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.DataConstants.Genre;

namespace Watchlist.Data.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxGenreName)]

        public string Name { get; set; } = null!;

    }
}
