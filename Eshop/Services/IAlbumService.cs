using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public interface IAlbumService
    {
        Task<Album?> AddAlbum(AlbumAddDTO dto);
        Task<List<Album>> GetAllAlbums();
        Task<Album?> GetAlbumById(int albumId);
        Task<Album?> UpdateAlbum(AlbumUpdateDTO dto);
        Task<bool> DeleteAlbumById(int albumId);
    }
}
