namespace Eshop.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Album>? Albums { get; }
    }
}
