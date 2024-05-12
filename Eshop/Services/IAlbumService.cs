using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public interface IAlbumService
    {
        Album? AddAlbum(AlbumAddDTO dto);
        Album? GetAlbumById(int albumId);
        Album? UpdateAlbum(AlbumUpdateDTO dto);
        void DeleteAlbumById(int albumId);
        IList<Album> GetAllAlbums();
    }
}
