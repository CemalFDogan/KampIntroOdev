using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System.Collections.Generic;

namespace GamerManagerSystem.Concrete
{
    public class CampaignManager : ICampaignService
    {     
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            System.Console.WriteLine($"{campaign.CampaignName} Başarılı Bir Şekilde Eklendi.");
        }
        
        public void Delete(Campaign campaign)
        {
            System.Console.WriteLine($"Silmek istenilen Kampanya : {campaign.CampaignName}" + "\n" 
                + "Lütfen bekleyin. Siliniyor!");

            campaigns.Remove(campaign);
            System.Console.WriteLine("Kampanya Başarılı Bir Şekilde Silindi.");
        }

        public void List()
        {
            System.Console.WriteLine("---- Kampanyalar ----");
            foreach (Campaign campaign1 in campaigns)
            {
                System.Console.WriteLine(campaign1.CampaignName) ;
            }
            System.Console.WriteLine("Kampanyalar Başarılı Bir Şekilde Listelendi.");
        }

        public void Update(Campaign campaign)
        {
            System.Console.WriteLine("Silmek istediğiniz kampanyanın adını girin:");
            campaign.CampaignName = System.Console.ReadLine();
            
            System.Console.WriteLine("Kampanya Başarılı Bir Şekilde Güncellendi.");
        }
    }
}
