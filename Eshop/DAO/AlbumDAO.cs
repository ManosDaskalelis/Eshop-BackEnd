using Eshop.Data;
using Eshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.DAO
{
    public class AlbumDAO : IAlbumDAO
    {
        private readonly DataContext _dataContext;

        public AlbumDAO(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Album? GetAlbumById(int albumId)
        {
            return _dataContext.Set<Album>().Find(albumId);
        }

        public void DeleteAlbum(int albumId)
        {
            var album = _dataContext.Set<Album>().Find(albumId);
            if (album is not null)
            {
                _dataContext.Set<Album>().Remove(album);
                _dataContext.SaveChanges();
            }
        }

        public List<Album> GetAllAlbums()
        {
            var albums = _dataContext.Albums.ToList();
            return albums;
        }

        public Album? AddAlbum(Album album)
        {
            var albumInserted = _dataContext.Add(album);
            _dataContext.SaveChanges();

            return albumInserted.Entity;
        }

        public Album? UpdateAlbum(Album album)
        {
            _dataContext.Entry(album).State = EntityState.Modified;
            _dataContext.SaveChanges();

            return album;
        }
    }
}
