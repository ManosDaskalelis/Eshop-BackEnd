using Eshop.DAO;
using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public interface IAlbumService
    {
        //Album? AddAlbum(AlbumAddDTO dto);
        Album? GetAlbumById(int id);
        //Album? UpdateAlbum(AlbumUpdateDTO dto);
        void DeleteAlbum(int albumId);
        List<Album> GetAllAlbums();
    }
}
