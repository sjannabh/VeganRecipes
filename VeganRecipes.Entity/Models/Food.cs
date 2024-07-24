using System.Text.Json.Serialization;

namespace VeganRecipes.Entity.Models
{

    public class Food
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }

        [JsonPropertyName("portion")]
        public string Portion { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("ingredients")]
        public List<string> Ingredients { get; set; }

        [JsonPropertyName("method")]
        public List<MethodCls> Method { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        public class MethodCls
        {
            [JsonPropertyName("Step 1")]
            public string Step1 { get; set; }

            [JsonPropertyName("Step 2")]
            public string Step2 { get; set; }
        }

    }
}
