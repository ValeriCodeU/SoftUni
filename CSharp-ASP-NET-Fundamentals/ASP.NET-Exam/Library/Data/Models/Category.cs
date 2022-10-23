using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.Category;

namespace Library.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxCategoryName)]

        public string Name { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
