using Microsoft.AspNetCore.Mvc;
using trab1.Model;
using trab1.Repository;

namespace trab1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _repository;

        public CommentController(ICommentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var comments = _repository.GetAll();
            return Ok(comments);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Comment comment)
        {
            if (comment == null)
                return BadRequest();

            _repository.Add(comment);
            return Ok(comment);
        }
    }
}