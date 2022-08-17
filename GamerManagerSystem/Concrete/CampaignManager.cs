using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System.Collections.Generic;
using System;

namespace GamerManagerSystem.Concrete
{
    public class CampaignManager : ICampaignService
    {     
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine($"{campaign.CampaignName} Başarılı Bir Şekilde Eklendi.");
        }
        
        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"Silmek istenilen Kampanya : {campaign.CampaignName}" + "\n" 
                + "Lütfen bekleyin. Siliniyor!");

            campaigns.Remove(campaign);
            Console.WriteLine("Kampanya Başarılı Bir Şekilde Silindi.");
        }

        public void List()
        {
            Console.WriteLine("---- Kampanyalar ----");
            foreach (Campaign campaign1 in campaigns)
            {
                Console.WriteLine(campaign1.CampaignName) ;
            }
            Console.WriteLine("Kampanyalar Başarılı Bir Şekilde Listelendi.");
        }

        public void Update(Campaign campaign)
        {
            Console.Write("Güncellemek istediğiniz kampanyanın Id'sini girin:");
            campaign.Id = Convert.ToInt32(Console.ReadLine());
            campaign.CampaignName = Console.ReadLine();
            campaign.CampaignContent = Console.ReadLine();
            

            Console.WriteLine("Kampanya Başarılı Bir Şekilde Güncellendi.");
        }
    }
}
