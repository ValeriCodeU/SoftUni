﻿using TaskBoardApp.Models;

namespace TaskBoardApp.Contracts
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskBoardModel>> GetTaskBoardsAsync();

        Task AddTaskFormAsync(TaskFormModel model, string userId);       
    }
}
