﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Watchlist.Contracts;
using Watchlist.Models;

namespace Watchlist.Controllers
{
    [Authorize]

    public class MoviesController : Controller
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [HttpGet]

        public async Task<IActionResult> All()
        {
            var model = await movieService.GellAllAsync();

            return View(model);
        }

        [HttpGet]

        public async Task<IActionResult> Add()
        {
            var model = new AddMovieViewModel()
            {
                Genres = await movieService.GetGenresAsync()
            };

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await movieService.AddMovieAsync(model);

                return RedirectToAction(nameof(All));
                
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Invalid operation");

                return View(model);
            }
        }

        public async Task<IActionResult> AddToCollection(int movieId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId != null)
            {
                await movieService.AddMovieToCollectionAsync(movieId, userId);
               
            }

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Watched()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await movieService.GetWatchedAsync(userId);

            return View(model);
        }

        public async Task<IActionResult> RemoveFromCollection(int movieId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            await movieService.RemoveMovieFromCollectionAsync(movieId, userId);

            return RedirectToAction(nameof(Watched));
        }
    }
}
