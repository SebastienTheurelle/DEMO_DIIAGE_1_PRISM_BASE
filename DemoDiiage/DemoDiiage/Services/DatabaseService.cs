using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoDiiage.Models.Entities;
using DemoDiiage.Repositories.Interface;
using DemoDiiage.Services.Interfaces;

namespace DemoDiiage.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IRepository<MovieEntity> _movieRepository;

        public DatabaseService(IRepository<MovieEntity> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        #region Movies

        public MovieEntity InsertMovie(MovieEntity movie)
        {
            try
            {
                return _movieRepository.Insert(movie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public MovieEntity GetMovieById(int id)
        {
            try
            {
                return _movieRepository.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public void DeleteMovie(MovieEntity movie)
        {
            try
            {
                _movieRepository.Delete(movie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<MovieEntity> GetMovies()
        {
            try
            {
                return _movieRepository.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        #endregion
    }
}