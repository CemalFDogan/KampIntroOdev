using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID -- Interface Segregation

            // 3 farklı çalışan tipi olduğunu varsayalım; Müdür, İşçi, Robot
            // 3 farklı eylemimiz var ---> Çalışmak, Yemek, Maaş almak

            
            // Çalışanlara çalış emri verir.
            IWorker[] workers = new IWorker[] 
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            // Çalışanlara yeme emri verir.
            IEat[] eats = new IEat[] 
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            // Maaş verir.
            IGetSalary[] getSalaries = new IGetSalary[]
            {
                new Manager(),
                new Worker()
            };

            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }



        }
    }
    // Interfaces
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    // Workers
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            // Manager eats.
            Console.WriteLine("Yemek yiyebilirsiniz.");
        }

        public void GetSalary()
        {
            // Manager gets salary.
            Console.WriteLine("Maaşınız yatırılmıştır.");
        }

        public void Work()
        {
            // Manager works.
            Console.WriteLine("Bütün çalışanlar iş başına!!");
        }
    }

    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            // Worker eats.
            Console.WriteLine("Yemek yiyebilirsiniz.");
        }

        public void GetSalary()
        {
            // Worker gets salary.
            Console.WriteLine("Maaşınız yatırılmıştır.");
        }

        public void Work()
        {
            // Worker works.
            Console.WriteLine("Bütün çalışanlar iş başına!!");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            // Robot sadece çalışır, ne yemek yer ne de maaş alır.
            Console.WriteLine("Bütün çalışanlar iş başına!!");
        }
    }
}

