namespace Eshop.Models
{
    public class Song
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }

        // Foreign key - to link to the Album
        public int AlbumId { get; set; }

        public virtual Album? Album { get; set; }
    }
}
