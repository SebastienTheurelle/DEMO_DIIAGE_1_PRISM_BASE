using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DemoDiiage.Models.Dtos
{
    public class MovieDownDto
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("slug")] public string Slug { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("overview")] public string Overview { get; set; }

        [JsonProperty("tagline")] public string Tagline { get; set; }

        [JsonProperty("classification")] public object Classification { get; set; }

        [JsonProperty("runtime")] public int Runtime { get; set; }

        [JsonProperty("released_on")] public DateTime ReleasedOn { get; set; }

        [JsonProperty("has_poster")] public bool HasPoster { get; set; }

        [JsonProperty("poster_blur")] public object PosterBlur { get; set; }

        [JsonProperty("has_backdrop")] public bool HasBackdrop { get; set; }

        [JsonProperty("backdrop_blur")] public object BackdropBlur { get; set; }

        [JsonProperty("imdb_rating")] public double? ImdbRating { get; set; }

        [JsonProperty("rt_critics_rating")] public object RtCriticsRating { get; set; }

        [JsonProperty("reelgood_score")] public object ReelgoodScore { get; set; }

        [JsonProperty("genres")] public List<int> Genres { get; set; }

        [JsonProperty("tracking")] public bool Tracking { get; set; }

        [JsonProperty("watchlisted")] public bool Watchlisted { get; set; }

        [JsonProperty("seen")] public bool Seen { get; set; }

        [JsonProperty("season_count")] public int SeasonCount { get; set; }

        [JsonProperty("content_type")] public string ContentType { get; set; }
    }
}