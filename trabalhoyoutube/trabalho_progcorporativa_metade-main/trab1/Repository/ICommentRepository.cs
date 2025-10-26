using trab1.Model;

namespace trab1.Repository
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll();
        Comment? GetById(Guid id);
        void Add(Comment comment);
    }
}