using GamerManagerSystem.Abstract;
using GamerManagerSystem.Concrete;

namespace GamerManagerSystem.Entities
{
    public class Campaign :IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignContent { get; set; }
    }
}

    
