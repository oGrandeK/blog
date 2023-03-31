namespace Blog.ViewModels.Posts;

public class ListPostsViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
    public DateTime LastUpdateDate { get; set; }
    public string Category { get; set; } = String.Empty;
    public string Author { get; set; } = String.Empty;
}