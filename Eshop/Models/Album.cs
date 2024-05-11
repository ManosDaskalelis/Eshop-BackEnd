namespace Eshop.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual ICollection<Song>? Songs { get; }
    }
}
