using Eshop.DTO;
using Eshop.Models;
using Eshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }


        [HttpGet("GetAlbums")]
        public IEnumerable<Album> GetAlbums()
        {
            var list = _albumService.GetAllAlbums();
            return list;
        }

        [HttpPost("AddAlbum")]
        public Album? PostAlbum(AlbumAddDTO albumDto) 
        {
            var album = _albumService.AddAlbum(albumDto);
            return album;
        }

        [HttpPatch("UpdateAlbum")]
        public Album? UpdateAlbum(AlbumUpdateDTO albumDto)
        {
            var album = _albumService.UpdateAlbum(albumDto);
            return album;
        }

        [HttpGet("GetAlbumById/{id}")]
        public Album? GetAlbumById(int albumId)
        {
            var album = _albumService.GetAlbumById(albumId);
            return album;
        }

        [HttpDelete("DeleteAlbumById/{id}")]
        public void DeleteAlbum(int albumId)
        {
            _albumService.DeleteAlbumById(albumId);
        }
    }
}
