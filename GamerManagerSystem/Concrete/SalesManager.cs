using GamerManagerSystem.Entities;
using System;

namespace GamerManagerSystem.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine($"Oyunun Adı: {game.GameName}");
            Console.WriteLine($"Oyunun Kategorisi: {game.GameCategory}");
            Console.WriteLine($"Oyunun Fiyatı: {game.GamePrice} ₺");
        }
    }
}
