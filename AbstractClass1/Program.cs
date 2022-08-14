using System;

namespace AbstractClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki örnekte Save() metodu her iki işlemde de aynı sonucu döndürürken,
            // Add() metodu aynı metot olmasına rağmen ikisi de kendisine göre o metodu çalıştırdı.

            MevzuatBase mevzuatA = new MevzuatA();
            mevzuatA.Add();
            mevzuatA.Save();

            MevzuatBase mevzuatB = new MevzuatB();
            mevzuatB.Add();
            mevzuatB.Save();

        }
    }

    abstract class MevzuatBase
    {
        public abstract void Add();   // ---> Interface'te olduğu gibi imza metodu tutabilir.

        public void Save()            // ---> Class'larda olduğu gibi ortak olan aynı şekilde ve biçimde gerçekleşmesi 
        {                             //      gereken metotları tutabilir.

            Console.WriteLine("Mevzuat kaydedildi.");

        }
    }

    class MevzuatA : MevzuatBase      // Implement edilmiş gibi görünse de aslında inherit ediliyor.
    {
        public override void Add()    // İmza metot, MevzuatA class'ına abstract class'tan geçerken  override olur.
        {
            
            Console.WriteLine("Mevzuat A eklendi");
        }
    }

    class MevzuatB : MevzuatBase
    {
        public override void Add()
        {
            Console.WriteLine("Mevzuat B eklendi");
        }
    }
}
