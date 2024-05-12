using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public interface ISongService
    {
        Song? AddSong(SongAddDTO dto);
        Song? GetSongById(int songId);
        Song? UpdateSong(SongUpdateDTO dto);
        void DeleteSongById(int songId);
        IList<Song> GetAllSongs();
    }
}
