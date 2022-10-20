﻿using System.Collections;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Board;

namespace TaskBoardApp.Data.Entities
{
    public class Board
    {
        public Board()
        {
            Tasks = new List<Task>();
        }
        public int Id { get; init; }

        [Required]
        [MaxLength(MaxBoardName)]

        public string Name { get; init; }

        public ICollection<Task> Tasks { get; set; }
    }
}
