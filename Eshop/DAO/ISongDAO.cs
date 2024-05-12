using Eshop.Models;

namespace Eshop.DAO
{
    public interface ISongDAO
    {
        Song? AddSong(Song song);
        Song? GetSongById(int songId);
        IList<Song> GetAllSongs();
        Song? UpdateSong(Song song);
        void DeleteSongById(int songId);
    }
}
