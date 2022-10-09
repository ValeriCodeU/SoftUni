using ForumApp.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ForumApp.Constants.DataConstants.Post;

namespace ForumApp.Data.Models
{
    [Comment("Published posts")]
    public class Post
    {
        [Key]
        [Comment("Post identifier")]

        public int Id { get; set; }

        [MaxLength(TitleMaxLength)]
        [Comment("Post title")]
        [Required]

        public string Title { get; set; } = null!;

        [MaxLength(ContentMaxLength)]
        [Comment("Post content")]
        [Required]

        public string Content { get; set; } = null!;
    }
}
