using System.Text.Json.Serialization;

namespace Blog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Slug { get; set; } = String.Empty;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IList<Post> Posts { get; set; } = new List<Post>();
    }
}