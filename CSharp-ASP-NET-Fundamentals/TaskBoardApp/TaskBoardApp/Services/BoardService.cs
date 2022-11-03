using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Services
{
    public class BoardService : IBoardService
    {
        private readonly TaskBoardAppDbContext dbContext;

        public BoardService(TaskBoardAppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }


        public async Task<IEnumerable<BoardViewModel>> GellAllAsync()
        {
            return await dbContext.Boards
                .Select(b => new BoardViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Tasks = b.Tasks.Select(t => new TaskViewModel()
                    {
                        Id = t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Owner = t.Owner.UserName
                    })
                }).ToListAsync();

          
        }

        public int GetTasksCount()
        {
            var tasksCount = dbContext.Tasks.Count();

            return tasksCount;
        }

        public List<HomeBoardModel> GetHomeBoardModel()
        {
            var taskBoards = dbContext.Boards.Select(b => b.Name).Distinct().ToList();

            var tasksCounts = new List<HomeBoardModel>();

            foreach (var boardName in taskBoards)
            {
                var taskInBoards = dbContext.Tasks.Where(t => t.Board.Name == boardName).Count();

                tasksCounts.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = taskInBoards
                });

            }

            return tasksCounts;
        }

        public HomeViewModel GetHomeViewModel(int usersTasksCount)
        {
            var homeModel = new HomeViewModel()
            {
                AllTasksCount = GetTasksCount(),
                BoardsWithTasksCount = GetHomeBoardModel(),
                UserTasksCount = usersTasksCount
            };

            return homeModel;
        }

        public int GetUserTasksCounts(string userId)
        {
            var userTasksCount = dbContext.Tasks.Where(t => t.OwnerId == userId).Count();

            return userTasksCount;
        }
    }
}
