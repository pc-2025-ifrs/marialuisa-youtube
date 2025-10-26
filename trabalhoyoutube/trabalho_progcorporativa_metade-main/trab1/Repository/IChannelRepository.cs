using trab1.Model;

namespace trab1.Repository
{
    public interface IChannelRepository
    {
        IEnumerable<Channel> GetAll();
        Channel? GetById(Guid id);
        void Add(Channel channel);
    }
}