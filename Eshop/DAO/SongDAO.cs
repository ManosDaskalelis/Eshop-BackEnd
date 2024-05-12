using Eshop.Data;
using Eshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.DAO
{
    public class SongDAO : ISongDAO
    {
        private readonly DataContext _dataContext;

        public SongDAO(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Song? AddSong(Song song)
        {
            var songInserted = _dataContext.Add(song);
            _dataContext.SaveChanges();
            return songInserted.Entity;
        }

        public void DeleteSongById(int songId)
        {
            var song = _dataContext.Set<Song>().Find(songId);
            if (song is not null) 
            {
                _dataContext.Set<Song>().Remove(song);
                _dataContext.SaveChanges();
            }
        }

        public IList<Song> GetAllSongs()
        {
            var songs = _dataContext.Songs.ToList();
            return songs;
        }

        public Song? GetSongById(int songId)
        {
            return _dataContext.Set<Song>().Find(songId);
        }

        public Song? UpdateSong(Song song)
        {
            _dataContext.Entry(song).State = EntityState.Modified;
            _dataContext.SaveChanges();

            return song;
        }
    }
}
