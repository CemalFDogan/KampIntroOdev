using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;

namespace GamerManagerSystem.Concrete
{
    public class SalesManager : ISalesService
    {
        
        public void AddToCart(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("----------- Sepet İşlemleri------------");
            Console.WriteLine($"Oyunun Adı: {game.GameName}");
            Console.WriteLine($"Oyunun Fiyatı: {game.GamePrice} --- {campaign.CampaignName} -> {campaign.CampaignContent}");
            Console.WriteLine($"Oyunu Alan Oyuncu: {gamer.FirstName} {gamer.LastName}");
        }
    }
}
