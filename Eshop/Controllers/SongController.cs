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

        [HttpGet("GetSongById/{id}")]
        public Song? GetSongById(int songId)
        {
            var song = _songService.GetSongById(songId);
            return song;
        }

        [HttpPost("AddSongs")]
        public Song? PostAlbum(SongAddDTO songDto)
        {
            var song = _songService.AddSong(songDto);
            return song;
        }

        [HttpPatch("UpdateSong")]
        public Song? UpdateSong(SongUpdateDTO songDto)
        {
            var song = _songService.UpdateSong(songDto);
            return song;
        }

        [HttpDelete("DeleteSongById/{id}")]
        public void DeleteSong(int songId)
        {
            _songService.DeleteSongById(songId);
        }


    }
}
