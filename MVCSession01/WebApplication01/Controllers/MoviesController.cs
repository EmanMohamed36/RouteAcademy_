using Microsoft.AspNetCore.Mvc;
using WebApplication01.Models;

namespace WebApplication01.Controllers
{
    public class MoviesController:Controller
    {
        //public string Index(int? id,string name)
        //{
        //    //return string.Empty;
        //    //return "eman mohamed ibrahem";
        //    return $"ID: {id} :: Name: {name}";
        //}

        //Get BaseUrl/Movies/GetMovie?id=10&name=filmename

        public string Index()
        {
            return "Hello form Index";
        }
        #region Example01
        //[HttpGet]
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = $"Movie:: {id} </br> {name}";
        //    //result.ContentType = "text/html" ;
        //    //result.StatusCode = 700 ;
        //    //return result;

        //    return Content($"Movie:: {id} </br> {name}", "text/html");
        //} 
        #endregion

        #region Example02
        [HttpGet]
        public IActionResult GetMovie(int? id, string name)
        {
            if (id == 0) return BadRequest();
            else if (id < 10) return NotFound();
            else return Content($"Movie:: {id} </br> {name}", "text/html");
        }

        #endregion

        #region Example03

        //Get Base Url / Movies/TestRedirectToAction
        [HttpGet]
        public IActionResult TestRedirectToAction()
        {
            return RedirectToRoute(new { Controller = "Movies", Action = "GetMovie", id = 16, name = "eman mohamed" });
            //return RedirectToAction(nameof(GetMovie), "Movies", new {id=15 ,name="eman"});
            //return RedirectToAction("GetMovie", "Movies", new {id=15 , name="eman"});
            //return Redirect("https://localhost:7133/movies/GetMovie?id=10&name=test");
            //return Redirect("https://www.amazon.com/");
        }
        #endregion

        [HttpPost]
        public IActionResult TestModelBindeing([FromQuery]  int  id , string name)
        {
            return Content($"Hello {name} your id is {id}");
        }
        
        //[HttpPost]
        //public IActionResult AddMovie([FromBody] Movie movie) //[FromHeader] Movie movie X (Header should bind simple data)
        //{
        //    if(movie is null) return BadRequest();
        //    return Content($"Movie Id: {movie.Id} , Title: {movie.Title}");
        //}

        //[HttpGet]
        //public IActionResult AddMovie(int Id , Movie movie,string Title) 
        //{
            
        //    return Content($"Movie Id: {movie.Id} , Title: {movie.Title}");
        //}
        [HttpGet]
        public IActionResult AddMovie(int Id, Movie movie, string Title, int[]arr)
        {

            return Content($"Movie Id: {movie.Id} , Title: {movie.Title}</br>{arr[0]}  {arr[1]}","text/html");
        }

    }
}
