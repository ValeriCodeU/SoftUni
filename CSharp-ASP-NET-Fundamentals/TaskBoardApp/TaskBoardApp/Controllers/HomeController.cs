using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class HomeController : BaseController
    {       
        private readonly IBoardService boardService;

        public HomeController(IBoardService _boardService, TaskBoardAppDbContext _dbContext)
        {            
            boardService = _boardService;           
        }

        public IActionResult Index()
        {           
            var usersTasksCount = -1;

            if (this.User?.Identity?.IsAuthenticated ?? false)
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (userId != null)
                {
                    usersTasksCount = boardService.GetUserTasksCounts(userId);
                }

            }

            var homeModel = boardService.GetHomeViewModel(usersTasksCount);

            return View(homeModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}