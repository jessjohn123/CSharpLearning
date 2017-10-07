using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Services
{
    public class EntertainmentServices : IEntertainmentServices
    {
        public IEnumerable<Games> GetGames()
        {
           return new List<Games>()
            {
                new Models.Games(){Title = "The Witcher", Genre ="RPG" },
                new Models.Games(){ Title = "Need For Speed", Genre="Racing"},
                new Models.Games(){ Title = "Uncharted", Genre="RolePlaying"},
                new Models.Games(){Title="Crysis", Genre="FPS"},
            };
        }

        public IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>()
            {
                new Movies(){ Title = "Star Wars", Ranking = 1},
                new Movies(){Title="Inception", Ranking = 2},
                new Movies(){ Title="Ghost in the Shell", Ranking = 3}
            };
        }
    }
}
