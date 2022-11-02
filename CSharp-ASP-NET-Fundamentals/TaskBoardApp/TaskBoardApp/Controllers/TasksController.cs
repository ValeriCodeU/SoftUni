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

        public TasksController(ITaskService _taskService, TaskBoardAppDbContext _dbContext)
        {
            taskService = _taskService;
            dbContext = _dbContext;
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

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpGet]

        public async Task<IActionResult> Edit (int id)
        {
            //var task = await dbContext.Tasks.FindAsync(id);
            var task = await taskService.GetTaskEntity(id);

            if (task == null)
            {
                return BadRequest();
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (task.OwnerId != userId)
            {
                return Unauthorized();
            }

            var model = await taskService.GetEditTaskFormAsync(task);

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, TaskFormModel model)
        {
            //var task = await dbContext.Tasks.FindAsync(id);
            var task = await taskService.GetTaskEntity(id);

            if (task == null)
            {
                return BadRequest();
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (task.OwnerId != userId)
            {
                return Unauthorized();
            }

            var boards = await taskService.GetTaskBoardsAsync();

            if (!boards.Any(b => b.Id == model.BoardId))
            {
                ModelState.AddModelError(nameof(model.BoardId), "Board doest not exist.");
            }

            await taskService.EditTaskFormAsync(model, task);

            return RedirectToAction("All", "Boards");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var task = await taskService.GetTaskEntity(id);

            if (task == null)
            {
                return BadRequest();
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (task.OwnerId != userId)
            {
                return Unauthorized();
            }

            var model = await taskService.GetDeleteTaskAsync(task);

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Delete (TaskViewModel model)
        {
            var task = await taskService.GetTaskEntity(model.Id);

            if (task == null)
            {
                return BadRequest();
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (task.OwnerId != userId)
            {
                return Unauthorized();
            }

            await taskService.DeleteTaskAsync(task);

            return RedirectToAction("All", "Boards");
        }
    }
}
