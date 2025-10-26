using Microsoft.AspNetCore.Mvc;
using trab1.Model;
using trab1.Repository;

namespace trab1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicRepository _repository;

        public MusicController(IMusicRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var musics = _repository.GetAll();
            return Ok(musics);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Music music)
        {
            if (music == null)
                return BadRequest();

            _repository.Add(music);
            return Ok(music);
        }
    }
}