using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class TasksController : Controller
    {

        private readonly TaskBoardAppDbContext dbContext;

        private readonly ITaskService taskService;  

        public TasksController(ITaskService _taskService)
        {
            taskService = _taskService;
        }

        public async Task <IActionResult> Create()
        {
            var model = new TaskFormModel()
            {
                Boards = await taskService.GetTaskBoardsAsync()
            };

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Create(TaskFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var boards = await taskService.GetTaskBoardsAsync();

            if (!boards.Any(b => b.Id == model.BoardId))
            {
                ModelState.AddModelError(nameof(model.BoardId), "Board doest not exist.");
            }

            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;



            if (userId != null)
            {
                await taskService.AddTaskFormAsync(model, userId);
            }

            return RedirectToAction("All", "Boards");
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await taskService.GetTaskDetailsAsync(id);

            //var model = await dbContext.Tasks
            //   .Where(t => t.Id == id)
            //   .Select(t => new TaskDetailsViewModel()
            //   {
            //       Id = t.Id,
            //       Title = t.Title,
            //       Description = t.Description,
            //       CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
            //       Board = t.Board.Name,
            //       Owner = t.Owner.UserName
            //   }).FirstOrDefaultAsync();

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }
    }
}
