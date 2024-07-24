

using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using VeganRecipes.DataAccess.Repository.IRepository;
using VeganRecipes.Entity.Models;

namespace VeganRecipes.DataAccess.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        public FoodRepository(IConfiguration config)
        {
            _config = config;
            string baseUri = _config["VeganFoodList:BaseUrl"];
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUri);
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client.DefaultRequestHeaders.Add("x-rapidapi-host", _config["VeganFoodList:host"]);
            _client.DefaultRequestHeaders.Add("x-rapidapi-key", _config["VeganFoodList:key"]);

        }
        public async Task<Food> DetailedFoodRecipeByID(string id)
        {
            return await _client.GetFromJsonAsync<Food>("/" + id);
        }

        public async Task<IEnumerable<FoodList>> ListOfFoods()
        {
            return await _client.GetFromJsonAsync<IEnumerable<FoodList>>("/");
        }
    }
}
