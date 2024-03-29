﻿using TaskBoardApp.Models;

namespace TaskBoardApp.Contracts
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskBoardModel>> GetTaskBoardsAsync();

        Task AddTaskFormAsync(TaskFormModel model, string userId);

        Task<TaskDetailsViewModel> GetTaskDetailsAsync(int id);

        Task EditTaskFormAsync(TaskFormModel model, Data.Entities.Task task);

        Task<TaskFormModel> GetEditTaskFormAsync(Data.Entities.Task task);
        
        Task<Data.Entities.Task> GetTaskEntity(int id);

        Task<TaskViewModel> GetDeleteTaskAsync(Data.Entities.Task task);

        Task DeleteTaskAsync(Data.Entities.Task task);
    }
}
