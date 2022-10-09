using ForumApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumApp.Data.Configure
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPosts();

            builder.HasData(posts);
        }

        private List<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Note1",
                    Content = "The weather is cold"
                },
                 new Post()
                {
                    Id = 2,
                    Title = "Note2",
                    Content = "Typical еnglish weather"
                },
                  new Post()
                {
                    Id = 3,
                    Title = "Note3",
                    Content = "The summer is over"
                },
            };
        }
    }
}
