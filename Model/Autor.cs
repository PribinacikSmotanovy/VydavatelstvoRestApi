namespace VydavatelstvoRestApi.Model
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Name { get; set; }
        
        public ICollection<Book>? Books { get; set; }
    }
}
