using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
//using static ForumApp.Constants.DataConstants.Post;
using static ForumApp.Constants.DataConstants.Post;

namespace ForumApp.Models
{
    public class PostFormModel
    {
        [Display(Name = "Title")]
        //[MinLength(TitleMinLength)]
        //[MaxLength(TitleMaxLength)]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "The field {0} must be between {2} and {1} symbols")]

        [Required]

        public string Title { get; set; } = null!;

        [Display(Name = "Content")]
        //[MinLength(ContentMinLength)]
        //[MaxLength(ContentMaxLength)]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = "The field {0} must be between {2} and {1} symbols")]
        [Required]

        public string Content { get; set; } = null!;
    }
}

