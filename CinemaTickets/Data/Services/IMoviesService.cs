using CinemaTickets.Data.Base;
using CinemaTickets.Data.ViewModels;
using CinemaTickets.Models;

namespace CinemaTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropDownsVM> GetNewMovieDropDownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
