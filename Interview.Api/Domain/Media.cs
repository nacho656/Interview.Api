namespace Interview.Api.Domain
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public bool IsActive { get; set; }
        public virtual Genre Genre { get; set; }

        //Todo: Add Media Type Property with Lookup Table that has data of: Movie, TV Show         
    }
}
