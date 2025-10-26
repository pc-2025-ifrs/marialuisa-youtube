using trab1.Model;

namespace trab1.Repository
{
    public interface IMusicRepository
    {
        IEnumerable<Music> GetAll();
        Music? GetById(Guid id);
        void Add(Music music);
    }
}