namespace TaskBoardApp.Models
{
    public class HomeViewModel
    {
        public int AllTasksCount { get; init; }

        public ICollection<HomeBoardModel> BoardsWithTasksCount { get; init; } = new List<HomeBoardModel>();

        public int UserTasksCount { get; init; }
    }
}
