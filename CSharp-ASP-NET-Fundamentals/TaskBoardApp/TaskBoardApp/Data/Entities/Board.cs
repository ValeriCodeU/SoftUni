﻿using System.Collections;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Board;

namespace TaskBoardApp.Data.Entities
{
    public class Board
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(MaxBoardName)]

        public string Name { get; init; } = null!;

        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
