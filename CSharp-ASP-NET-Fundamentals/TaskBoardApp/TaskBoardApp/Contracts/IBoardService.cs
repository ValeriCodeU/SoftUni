using TaskBoardApp.Data.Entities;
using TaskBoardApp.Models;

namespace TaskBoardApp.Contracts
{
    public interface IBoardService
    {
        Task<IEnumerable<BoardViewModel>> GellAllAsync();

        int GetTasksCount();

        List<HomeBoardModel> GetHomeBoardModel();

        HomeViewModel GetHomeViewModel(int usersTasksCount);

        int GetUserTasksCounts(string userId);
    }
}
