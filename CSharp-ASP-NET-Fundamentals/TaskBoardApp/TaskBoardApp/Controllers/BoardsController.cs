using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
	public class BoardsController : Controller
	{
		private readonly TaskBoardAppDbContext dbContext;

		public BoardsController(TaskBoardAppDbContext _dbContext)
		{
			dbContext = _dbContext;
		}

		public async Task<IActionResult> All()
		{
			var model = dbContext.Boards
				.Select(b => new BoardViewModel()
				{
					Id = b.Id,
					Name = b.Name,
					Tasks = b.Tasks.Select(t => new TaskViewModel()
					{
						Id = t.Id,
						Title = t.Title,
						Description = t.Description,
						Owner = t.Owner.UserName
					})
				}).ToListAsync();

			return View(model);
		}
	}
}
