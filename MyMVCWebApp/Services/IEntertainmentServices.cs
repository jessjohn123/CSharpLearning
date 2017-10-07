using MyMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCWebApp.Services
{
    public interface IEntertainmentServices
    {
        IEnumerable<Games> GetGames();
        IEnumerable<Movies> GetMovies();
    }
}
