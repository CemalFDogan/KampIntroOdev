using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi!!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi!!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi!!");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteriler listelendi !!");
        }
    }
}
