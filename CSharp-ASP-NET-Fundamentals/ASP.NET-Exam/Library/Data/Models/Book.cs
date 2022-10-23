//using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Data.DataConstants.Book;

namespace Library.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTitleBook)]

        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxAuthorName)]

        public string Author { get; set; } = null!;

        [Required]
        [MaxLength(MaxDescription)]

        public string Description { get; set; } = null!;

        [Required]

        public string ImageUrl { get; set; } = null!;

        [Column(TypeName = "decimal(5, 2)")]

        public decimal Rating { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]

        public Category Category { get; set; }

        public ICollection<ApplicationUserBook> ApplicationUsersBooks { get; set; } = new List<ApplicationUserBook>();
    }
}
