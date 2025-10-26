using Microsoft.AspNetCore.Mvc;
using trab1.Model;
using trab1.Repository;

namespace trab1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelController : ControllerBase
    {
        private readonly IChannelRepository _repository;

        public ChannelController(IChannelRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var channels = _repository.GetAll();
            return Ok(channels);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Channel channel)
        {
            if (channel == null)
                return BadRequest();

            
            _repository.Add(channel);
            return Ok(channel);
        }
    }
}