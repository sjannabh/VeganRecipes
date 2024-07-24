using VeganRecipes.Entity.Models;

namespace VeganRecipes.DataAccess.Repository.IRepository
{
    public interface IFoodRepository
    {
        Task<Food> DetailedFoodRecipeByID(string id);
        Task<IEnumerable<FoodList>> ListOfFoods();
    }
}
