namespace Movies.API.DTO.Movies
{
    public class UpdateMovie
    {
        // warto tu ustawiac na sam set jest tylko update?
        public int ID { get; set; }     
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
