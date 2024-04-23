using Eshop.DAO;
using Eshop.DTO;
using Eshop.Models;

namespace Eshop.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly AlbumDAO _albumDAO;

        public AlbumService(AlbumDAO albumDAO)
        {
            _albumDAO = albumDAO;
        }

        public Album GetAlbumById(int albumId)
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
        }

        public Album? UpdateAlbum(AlbumUpdateDTO dto)
        {
            _albumDAO.UpdateAlbum(album);
        }

        public List<Album> GetAllAlbums()
        {
            throw new NotImplementedException();
        }
    }
}
