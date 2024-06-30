namespace VydavatelstvoRestApi.Model
{
    public class AutorDTO
    {
        public int AutorId { get; set; }
        public string Name { get; set; }
        public IEnumerable<BookDTO>? Books { get; set; }
    }
}
