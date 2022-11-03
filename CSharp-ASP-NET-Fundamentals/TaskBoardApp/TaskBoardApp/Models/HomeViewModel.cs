namespace TaskBoardApp.Models
{
    public class HomeViewModel
    {
        public int AllTasksCoubt { get; init; }

        public ICollection<HomeBoardModel> BoardsWithTasksCount { get; init; } = new LinkedList<HomeBoardModel>();

        public int UserTasksCount { get; init; }
    }
}
