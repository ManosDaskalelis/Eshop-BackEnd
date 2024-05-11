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

        public Album? GetAlbumById(int albumId)
        {
            return _albumDAO.GetAlbumById(albumId);
        }

        public void DeleteAlbum(int albumId)
        {
            _albumDAO.DeleteAlbum(albumId);
        }

        public Album? AddAlbum(AlbumAddDTO dto)
        {
            var album = new Album()
            {
                Name = dto.Name
            };

            var insertedAlbum = _albumDAO.AddAlbum(album);

            return insertedAlbum;
        }

        public Album? UpdateAlbum(AlbumUpdateDTO dto)
        {
            var album = new Album()
            {
                Name = dto.Name,
                Id = dto.Id
            };

            var updatedAlbum = _albumDAO.UpdateAlbum(album);
            return updatedAlbum;
        }

        public List<Album> GetAllAlbums()
        {
            var albums = _albumDAO.GetAllAlbums();
            return albums;
        }
    }
}
