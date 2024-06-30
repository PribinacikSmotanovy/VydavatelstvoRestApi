namespace VydavatelstvoRestApi.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public int AutorId {  get; set; }
        public Autor? Autor { get; set; }
        public string Title { get; set; }
    }
}
