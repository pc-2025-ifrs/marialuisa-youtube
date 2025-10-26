using trab1.Model;
using trab1.Data;

namespace trab1.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;

        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList(); 
        }

        public Comment? GetById(Guid id)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == id); 
        }

        public void Add(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}