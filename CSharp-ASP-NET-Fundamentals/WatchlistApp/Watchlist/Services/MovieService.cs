using Microsoft.EntityFrameworkCore;
using Watchlist.Contracts;
using Watchlist.Data;
using Watchlist.Data.Models;
using Watchlist.Models;

namespace Watchlist.Services
{
    public class MovieService : IMovieService
    {
        private readonly WatchlistDbContext contex;

        public MovieService(WatchlistDbContext _contex)
        {
            contex = _contex;
        }

        public async Task AddMovieAsync(AddMovieViewModel model)
        {
            var entity = new Movie()
            {
                Title = model.Title,
                Director = model.Director,
                ImageUrl = model.ImageUrl,
                Rating = model.Rating,
                GenreId = model.GenreId
            };

            await contex.Movies.AddAsync(entity);
            await contex.SaveChangesAsync();
        }

        public async Task AddMovieToCollectionAsync(int movieId, string userId)
        {
            //var user = await contex.Users.FirstOrDefaultAsync(u => u.Id == userId);

            var user = await contex.Users
               .Where(u => u.Id == userId)
               .Include(um => um.UsersMovies)
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user Id");
            }

            var movie = await contex.Movies.FirstOrDefaultAsync(m => m.Id == movieId);

            if (movie == null)
            {
                throw new ArgumentException("Invalid movie Id");
            }

            if (!user.UsersMovies.Any(um => um.MovieId == movieId))
            {
                user.UsersMovies.Add(new UserMovie
                {
                    MovieId = movieId,
                    UserId = userId
                });

                await contex.SaveChangesAsync();
            }

        
        }

        public async Task<IEnumerable<MovieViewModel>> GellAllAsync()
        {
            return await contex.Movies
                .Select(m => new MovieViewModel()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Director = m.Director,
                    ImageUrl = m.ImageUrl,
                    Rating = m.Rating,
                    Genre = m.Genre.Name

                }).ToListAsync();
        }

        public async Task<IEnumerable<MovieViewModel>> GetWatchedAsync(string userId)
        {
            var user = await contex.Users
                .Where(u => u.Id == userId)
                .Include(um => um.UsersMovies)
                .ThenInclude(um => um.Movie)
                .ThenInclude(m => m.Genre)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user Id");
            }

            return user.UsersMovies.Select(m => new MovieViewModel()
            {
                Id = m.Movie.Id,
                Title = m.Movie.Title,
                Director = m.Movie.Director,
                ImageUrl = m.Movie.ImageUrl,
                Rating = m.Movie.Rating,
                Genre = m.Movie.Genre.Name
            });
        }

        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await contex.Genres.ToListAsync();
        }

        public async Task RemoveMovieFromCollectionAsync(int movieId, string userId)
        {
            var user = await contex.Users
               .Where(u => u.Id == userId)
               .Include(um => um.UsersMovies)
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user Id");
            }

            var movie = user.UsersMovies.FirstOrDefault(m => m.MovieId == movieId);

            if (movie != null)
            {
                user.UsersMovies.Remove(movie);
                await contex.SaveChangesAsync();
            }
        }
    }
}
