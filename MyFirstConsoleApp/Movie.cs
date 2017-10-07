using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public enum MovieGenre
    {
        Action,
        Comedy,
        Romance, 
        Horror,
        Scifi
    }
    class Movie
    {
        public string MovieTitle { get; set; }
        public int MovieYear { get; set; }
        public MovieGenre Genre { get; set; }

        public Movie(string title, int year, MovieGenre genre)
        {
            MovieTitle = title;
            MovieYear = year;
            Genre = genre;
        }


    }
}
