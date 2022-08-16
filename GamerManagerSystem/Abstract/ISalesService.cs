using GamerManagerSystem.Entities;

namespace GamerManagerSystem.Concrete
{
    public interface ISalesService
    {
        void Sell(Game game, Campaign campaign, Gamer gamer);
    }
}