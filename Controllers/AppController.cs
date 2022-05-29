using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index(){
            //throw new InvalidOperationException();
            return View();
        }

        //Welcome
        public IActionResult Welcome(){
            //throw new InvalidOperationException();
            return View();
        }
    }
}