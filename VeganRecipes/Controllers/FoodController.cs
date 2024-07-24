using Microsoft.AspNetCore.Mvc;

namespace VeganRecipes.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult ViewAll()
        {
            return View();
        }
    }
}
