using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
<<<<<<< Updated upstream
    // api/examples
=======
>>>>>>> Stashed changes
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }
<<<<<<< Updated upstream
        [HttpGet]
        public IActionResult GetPublishers()
        {
            var videoGamePublishers = _context.VideoGames.Select(vg => vg.Publisher).Distinct();

            return Ok(videoGamePublishers);
        }
        [HttpGet("{pubName}")]
        public IActionResult GetGamesbyPublisher(string pubName)
=======

        [HttpGet]
        public IActionResult GetGames()
        {
            var videoGames = _context.VideoGames;

            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public IActionResult GetGamesById(int id)
>>>>>>> Stashed changes
        {
            int? maxYear = _context.VideoGames.Select(vg => vg.Year).Max();
            int? minYear = _context.VideoGames.Select(vg => vg.Year).Min();

<<<<<<< Updated upstream
            var videoGames =_context.VideoGames.Where(vg => vg.Publisher == pubName);
=======
            var videoGames = _context.VideoGames.Where(vg => vg.Id == id);
>>>>>>> Stashed changes
            return Ok(videoGames);
        }
    }
}
