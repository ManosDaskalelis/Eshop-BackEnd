using Eshop.Models;

namespace Eshop.DAO
{
    public interface IAlbumDAO
    {
         //Album? AddAlbum(Album album);
         Album? GetAlbumById(int albumId);
         List<Album> GetAllAlbums();
         //Album? UpdateAlbum(Album album);
         void DeleteAlbum(int albumId);

    }
}
