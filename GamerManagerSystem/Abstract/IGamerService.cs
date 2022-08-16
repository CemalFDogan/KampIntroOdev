using GamerManagerSystem.Entities;

namespace GamerManagerSystem.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
        void List();
    }
}
