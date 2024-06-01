using Eshop.Models;

namespace Eshop.DAO
{
    public interface IAlbumDAO
    {
        Task<Album?> AddAlbum(Album album);
        Task<Album?> GetAlbumById(int albumId);
        Task<List<Album>> GetAllAlbums();
        Task<Album?> UpdateAlbum(Album album);
        Task<bool> DeleteAlbumById(int albumId);
    }
}
