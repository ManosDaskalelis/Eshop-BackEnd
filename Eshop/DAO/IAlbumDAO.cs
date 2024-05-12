using Eshop.Models;

namespace Eshop.DAO
{
    public interface IAlbumDAO
    {
        Album? AddAlbum(Album album);
        Album? GetAlbumById(int albumId);
        IList<Album> GetAllAlbums();
        Album? UpdateAlbum(Album album);
        void DeleteAlbumById(int albumId);
    }
}
