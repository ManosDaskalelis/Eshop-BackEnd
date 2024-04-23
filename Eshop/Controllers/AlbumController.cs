using Eshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
      
        public AlbumController()
        {

        }

        [HttpGet("GetAlbums")]
        public IEnumerable<Album> GetAlbums()
        {
            var list = new List<Album>() { new Album() {Id = 1, Name = "To pimp a butterfly"} };
            return list;
        }

        [HttpPost("AddAlbum")]
        public IEnumerable<Album> PostAlbums(Album album) 
        {
            var list = new List<Album>();
            return list;
        }

    }
}
