using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVCWebApp.Models;
using MyMVCWebApp.Services;

namespace MyMVCWebApp.Controllers
{
    [Route("mypages")]
    public class PagesController : Controller
    {
        private IEntertainmentServices _service;

        //The service will be injected to the constructor
        public PagesController(IEntertainmentServices service)
        {
            _service = service;
        }

        [Route("mygames", Name = "MyGames")]
        public IActionResult Games()
        {
            /*ViewData["games"] = new List<Games>()
            {
                new Models.Games(){Title = "The Witcher", Genre ="RPG" },
                new Models.Games(){ Title = "Need For Speed", Genre="Racing"},
                new Models.Games(){ Title = "Uncharted", Genre="RolePlaying"},
                new Models.Games(){Title="Crysis", Genre="FPS"},
            };*/
            ViewData["games"] = _service.GetGames();
            return View();
        }

        [Route("mymovies", Name = "MyMovies")]
        public IActionResult Movies()
        {
            /*var movies = new List<Movies>()
            {
                new Movies(){ Title = "Star Wars", Ranking = 1},
                new Movies(){Title="Inception", Ranking = 2},
                new Movies(){ Title="Ghost in the Shell", Ranking = 3}
            };*/
            var movies = _service.GetMovies();
            return View(movies);
        }
    }
}