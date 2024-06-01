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
        public async Task<List<Album>> GetAlbums()
        {
            var list = await _albumService.GetAllAlbums();
            return list;
        }

        [HttpPost("AddAlbum")]
        public async Task<Album?> PostAlbum(AlbumAddDTO albumDto) 
        {
            var album = await _albumService.AddAlbum(albumDto);
            return album;
        }

        [HttpPatch("UpdateAlbum")]
        public async Task<Album?> UpdateAlbum(AlbumUpdateDTO albumDto)
        {
            var album = await _albumService.UpdateAlbum(albumDto);
            return album;
        }

        [HttpGet("GetAlbumById/{id}")]
        public async Task<Album?> GetAlbumById(int albumId)
        {
            var album = await _albumService.GetAlbumById(albumId);
            return album;
        }

        [HttpDelete("DeleteAlbumById/{id}")]
        public void DeleteAlbum(int albumId)
        {
            _albumService.DeleteAlbumById(albumId);
        }
    }
}
