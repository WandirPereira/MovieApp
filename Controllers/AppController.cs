using Microsoft.AspNetCore.Mvc;
using MovieApp.ViewModel;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        public static List<MovieViewModel> _movies = new List<MovieViewModel>();
        public IActionResult Index(){
            //throw new InvalidOperationException();
            return View(_movies);
        }

        //Welcome
        public IActionResult Welcome(){
            //throw new InvalidOperationException();
            return View();
        }
        public IActionResult AddOrEdit(Guid id){
            //throw new InvalidOperationException();
            var movie =_movies.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }
        
        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model){
            //throw new InvalidOperationException();
            var movie =_movies.FirstOrDefault(x => x.Id == model.Id);
            if(ModelState.IsValid){
                if (movie == null){
                    model.Id = Guid.NewGuid();
                    _movies.Add(model);  
                }else{
                    movie.Genre = model.Genre;
                    movie.Name = model.Name;
                }
                return RedirectToAction(nameof(Index));   
            }
            return View();
        }

       [HttpGet("about")]
         public IActionResult About(){
            //throw new InvalidOperationException();
            return View();
        }

    }
}