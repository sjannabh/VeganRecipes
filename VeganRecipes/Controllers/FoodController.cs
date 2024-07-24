using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using VeganRecipes.DataAccess.Repository.IRepository;
using VeganRecipes.Entity.Models;

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

        public async Task<IActionResult> ViewRecipe(string id)
        {
           var result = await _foodRepository.DetailedFoodRecipeByID(id);

           return View(result);
        }
    }
}
