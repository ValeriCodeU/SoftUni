using ForumApp.Data;
using ForumApp.Data.Models;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext data;

        public PostsController(ForumAppDbContext _data)
        {
            data = _data;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await data
                .Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();

            return View(posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };



            data.Posts.Add(post);
            await data.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(int id)
        {
            var post = await data.Posts.FindAsync(id);

            if (post == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var postModel = new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            };

            return View(postModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, PostFormModel model)
        {
            var post = await data.Posts.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (post != null)
            {
                post.Title = model.Title;
                post.Content = model.Content;

                await data.SaveChangesAsync();
            }           

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var post = await data.Posts.FindAsync(id);

            if (post != null)
            {
                data.Posts.Remove(post);
                await data.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));

        }
    }
}
