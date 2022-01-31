using System;

namespace DemoDiiage.Models.Entities.Interfaces
{
    public interface IMovieEntity
    {
        int Id { get; set; }
        string MovieId { get; set; }
        string Title { get; set; }
        string Overview { get; set; }
        DateTime ReleaseDate { get; set; }
        double? Rating { get; set; }
    }
}