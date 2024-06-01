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

        public async Task<Album?> AddAlbum(Album album)
        {
            var albumInserted = await _dataContext.AddAsync(album);
            await _dataContext.SaveChangesAsync();

            return albumInserted.Entity;
        }

        public async Task<Album?> GetAlbumById(int albumId)
        {
            return await _dataContext.Set<Album>().FindAsync(albumId);
        }

        public async Task<List<Album>> GetAllAlbums()
        {
            var albums = await _dataContext.Albums.ToListAsync();
            return albums;
        }

        public async Task<Album?> UpdateAlbum(Album album)
        {
            _dataContext.Entry(album).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();

            return album;
        }

        public async Task<bool> DeleteAlbumById(int albumId)
        {
            var album = await _dataContext.Set<Album>().FindAsync(albumId);
            if (album is not null)
            {
                _dataContext.Set<Album>().Remove(album);
                await _dataContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
