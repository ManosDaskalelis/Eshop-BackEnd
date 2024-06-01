using Eshop.DAO;
using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumDAO _albumDAO;

        public AlbumService(IAlbumDAO albumDAO)
        {
            _albumDAO = albumDAO;
        }

        public async Task<Album?> AddAlbum(AlbumAddDTO dto)
        {
            var album = new Album()
            {
                Name = dto.Name
            };

            var insertedAlbum = await _albumDAO.AddAlbum(album);
            return insertedAlbum;
        }

        public async Task<List<Album>> GetAllAlbums()
        {
            var albums = await _albumDAO.GetAllAlbums();
            return albums;
        }

        public async Task<Album?> GetAlbumById(int albumId)
        {
            return await _albumDAO.GetAlbumById(albumId);
        }

        public async Task<Album?> UpdateAlbum(AlbumUpdateDTO dto)
        {
            var album = new Album()
            {
                Name = dto.Name,
                Id = dto.Id
            };

            var updatedAlbum = await _albumDAO.UpdateAlbum(album);
            return updatedAlbum;
        }

        public async Task<bool> DeleteAlbumById(int albumId)
        {
            return await _albumDAO.DeleteAlbumById(albumId);
        }
    }
}
