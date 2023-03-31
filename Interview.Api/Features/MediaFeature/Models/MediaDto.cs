namespace Interview.Api.Features.MediaFeature.Models
{
    public class MediaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public bool IsActive { get; set; }
    }
}
