using Eshop.DTO;
using Eshop.Models;
using Eshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet("GetSongs")]
        public IEnumerable<Song> GetSongs()
        {
            var list = _songService.GetAllSongs();
            return list;
        }

        [HttpPost("AddSongs")]
        public Song? PostAlbum(SongAddDTO songDto)
        {
            var song = _songService.AddSong(songDto);
            return song;
        }







    }
}
