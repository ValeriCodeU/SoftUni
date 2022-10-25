﻿using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Task;

namespace TaskBoardApp.Models
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle, ErrorMessage = "Title should be at least {2} characters long.")]

        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxTaskDescription, MinimumLength = MinTaskDescription, ErrorMessage = "Description should be at least {2} characters long.")]

        public string Description { get; set; } = null!;

        [Display(Name = "Board?")]

        public int BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; } = new List<TaskBoardModel>();
    }
}
