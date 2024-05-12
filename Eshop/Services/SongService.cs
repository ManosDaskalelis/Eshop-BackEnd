using Eshop.DAO;
using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public class SongService : ISongService
    {
        private readonly ISongDAO _songDAO;

        public SongService(ISongDAO songDAO)
        {
            _songDAO = songDAO;
        }

        public Song? AddSong(SongAddDTO dto)
        {
            var song = new Song()
            {
                Name = dto.Name
            };

            var insertedSong = _songDAO.AddSong(song);

            return insertedSong;
        }

        public void DeleteSongById(int songId)
        {
            _songDAO.DeleteSongById(songId);
        }

        public IList<Song> GetAllSongs()
        {
            var songs = _songDAO.GetAllSongs();
            return songs;
        }

        public Song? GetSongById(int songId)
        {
            return _songDAO.GetSongById(songId);
        }

        public Song? UpdateSong(SongUpdateDTO dto)
        {
            var song = new Song()
            {
                Name = dto.Name,
                Id = dto.Id
            };
            
            var updatedSong = _songDAO.UpdateSong(song);
            return updatedSong;
        }
    }
}
