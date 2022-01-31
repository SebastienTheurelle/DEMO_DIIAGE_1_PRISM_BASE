using System;
using DemoDiiage.Models.Dtos;
using DemoDiiage.Models.Entities.Interfaces;
using SQLite;

namespace DemoDiiage.Models.Entities
{
    public class MovieEntity : IMovieEntity
    {
        public MovieEntity()
        {
            
        }
        public MovieEntity(MovieDownDto movie)
        {
            MovieId = movie.Id;
            Title = movie.Title;
            Overview = movie.Overview;
            ReleaseDate = movie.ReleasedOn;
            Rating = movie.ImdbRating;
        }

        [PrimaryKey] [AutoIncrement] public int Id { get; set; }
        public string MovieId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double? Rating { get; set; }
    }
}