using BasicBlazorMovieApp.Models;

namespace BasicBlazorMovieApp.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}
