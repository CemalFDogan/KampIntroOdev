using GamerManagerSystem.Concrete;
using GamerManagerSystem.Entities;

namespace GamerManagerSystem.Abstract
{
    public interface ICampaignService 
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void List();
    }
}