using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Concrete
{
    public class GamerManager : IGamerService
    {
        List<Gamer> gamers = new List<Gamer>();

        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName} Başarılı Bir Şekilde Eklendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"Silmek istenilen Oyuncu : {gamer.FirstName} {gamer.LastName}" + "\n"
                + "Lütfen bekleyin. Siliniyor!");

            gamers.Remove(gamer);
            Console.WriteLine("Oyuncu Başarılı Bir Şekilde Silindi.");
        }

        public void List()
        {
            System.Console.WriteLine("---- Oyuncular ----");
            foreach (Gamer gamer1 in gamers)
            {
                Console.WriteLine($"{gamer1.Id} : {gamer1.FirstName} {gamer1.LastName}");
            }
            Console.WriteLine("Oyuncular Başarılı Bir Şekilde Listelendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.Write("Güncellemek istediğiniz oyuncunun Id'sini girin:");
            gamer.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Oyuncunun Adı: ");
            gamer.FirstName = Console.ReadLine();

            Console.Write("Oyuncunun Soyadı: ");
            gamer.LastName = Console.ReadLine();
            

            Console.WriteLine($"Id numarası {gamer.Id} Olan Oyuncu Başarılı Bir Şekilde Güncellendi.");
        }
    }
}
