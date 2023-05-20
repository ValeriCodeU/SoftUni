using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
	public class BoardsController : BaseController
	{
		private readonly IBoardService boardService;

		public BoardsController(IBoardService _boardService)
		{
			boardService = _boardService;
		}

		public async Task<IActionResult> All()
		{
			var model = await boardService.GellAllAsync();

			return View(model);
		}
	}
}
