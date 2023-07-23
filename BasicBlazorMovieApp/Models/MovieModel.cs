namespace BasicBlazorMovieApp.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Review { get; set; } = string.Empty;

    }
}
