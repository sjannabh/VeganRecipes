using Microsoft.AspNetCore.Mvc;
using VeganRecipes.DataAccess.Repository.IRepository;

namespace VeganRecipes.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public FoodController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public async Task<IActionResult> ViewAll()
        {
            var result = await _foodRepository.ListOfFoods();
            return View(result);
        }
    }
}
