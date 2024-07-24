

using VeganRecipes.DataAccess.Repository.IRepository;
using VeganRecipes.Entity.Models;

namespace VeganRecipes.DataAccess.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public Task<Food> DetailedFoodRecipeByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FoodList>> ListOfFoods()
        {
            throw new NotImplementedException();
        }
    }
}
