using Microsoft.EntityFrameworkCore;
using System.Data;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskBoardAppDbContext dbContext;

        public TaskService(TaskBoardAppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task AddTaskFormAsync(TaskFormModel model, string userId)
        {
            var entity = new Data.Entities.Task()
            {
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                BoardId = model.BoardId,
                OwnerId = userId,
            };

            await dbContext.Tasks.AddAsync(entity);
            await dbContext.SaveChangesAsync();
          
        }

        public async Task<IEnumerable<TaskBoardModel>> GetTaskBoardsAsync()
        {
            return await dbContext.Boards.Select(b => new TaskBoardModel()
            {
                Id = b.Id,
                Name = b.Name

            }).ToListAsync();
        }

        public async Task<TaskDetailsViewModel> GetTaskDetailsAsync(int id)
        {
            
           return await dbContext.Tasks
                .Where(t => t.Id == id)
                
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board.Name,
                    Owner = t.Owner.UserName
                }).FirstAsync();
        }
    }
}
