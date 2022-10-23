using Library.Data.Models;
using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.Book;

namespace Library.Models
{
    public class AddBookViewModel
    {
        [Required]
        [MaxLength(MaxTitleBook)]
        [MinLength(MinTitleBook)]

        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxAuthorName)]
        [MinLength(MinAuthorName)]

        public string Author { get; set; } = null!;

        [Required]
        [MaxLength(MaxDescription)]
        [MinLength(MinDescription)]

        public string Description { get; set; }

        [Required]

        public string ImageUrl { get; set; } = null!;

        [Range(typeof(decimal), "0.00", "10.00", ConvertValueInInvariantCulture = true)]

        public decimal Rating { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
