using GamerManagerSystem.Abstract;
using GamerManagerSystem.Concrete;
using GamerManagerSystem.Entities;
using System;

namespace GamerManagerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kampanya işlemleri
            Console.WriteLine();
            Console.WriteLine("Kampanya İşlemleri");
            
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "3 Al 1 Öde";
            campaign1.CampaignContent = "3 KİTAP AL VE 1 KİTAP PARASI ÖDE";

            Campaign campaign2 = new Campaign() 
            {
                Id = 2, 
                CampaignName = "2 Al 1 Öde", 
                CampaignContent = "2 KİTAP AL VE 1 KİTAP PARASI ÖDE"
            };

            CampaignManager campaignManager = new CampaignManager();
            Console.WriteLine("------------------------");
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign1);
            Console.WriteLine("------------------------");
            Console.WriteLine();
            campaignManager.List();
            Console.WriteLine();
            campaignManager.Delete(campaign2);
            Console.WriteLine();
            campaignManager.List();

            // Oyuncu işlemleri
            Console.WriteLine();
            Console.WriteLine("Oyuncu İşlemleri");
            Console.WriteLine();

            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Cemal Faruk", LastName = "Doğan" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Bekir", LastName = "Doğan" };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            Console.WriteLine();
            gamerManager.List();
            Console.WriteLine();
            gamerManager.Delete(gamer2);
            Console.WriteLine();
            gamerManager.Update(gamer1);
            Console.WriteLine();
            gamerManager.List();

        }
    }
}
