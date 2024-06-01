namespace Eshop.Models
{
    public class Album
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
