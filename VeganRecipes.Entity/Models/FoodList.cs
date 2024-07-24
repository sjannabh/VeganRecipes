using System.Text.Json.Serialization;

namespace VeganRecipes.Entity.Models
{
    public class FoodList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
