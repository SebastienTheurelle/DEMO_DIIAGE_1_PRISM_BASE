using System.Collections.Generic;
using System.Threading.Tasks;
using DemoDiiage.Models.Entities;

namespace DemoDiiage.Services.Interfaces
{
    public interface IDatabaseService
    {
        MovieEntity InsertMovie(MovieEntity movie);
        MovieEntity GetMovieById(int id);
        void DeleteMovie(MovieEntity movie);
        List<MovieEntity> GetMovies();
    }
}