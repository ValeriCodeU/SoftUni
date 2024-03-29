﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
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

        public async Task DeleteTaskAsync(Data.Entities.Task task)
        {

            dbContext.Tasks.Remove(task);
            await dbContext.SaveChangesAsync();

        }

        public async Task EditTaskFormAsync(TaskFormModel model, Data.Entities.Task task)
        {
            task.Title = model.Title;
            task.Description = model.Description;
            task.BoardId = model.BoardId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<TaskViewModel> GetDeleteTaskAsync(Data.Entities.Task task)
        {
            var model = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
            };

            return model;
        }

        public async Task<TaskFormModel> GetEditTaskFormAsync(Data.Entities.Task task)
        {
            var model = new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                Boards = await GetTaskBoardsAsync()
            };

            return model;
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

        public async Task<Data.Entities.Task> GetTaskEntity(int id)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            return task;
        }
    }
}
