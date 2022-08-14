using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] 
            {
                new Customer{FirstName = "Cemal", City = "Bursa" },
                new Student{FirstName = "Engin", City = "Ankara" }
            };

            Console.WriteLine("-------------------------------");
            foreach (var person in people)
            {
                Console.WriteLine($"Adı: {person.FirstName} --- Memleket: {person.City}");
            }
            Console.WriteLine("-------------------------------");
        }
    }
    
    // Interface
    interface IGoShopping
    {
        void GoShopping();
    }

    // Classes
    class Person:IGoShopping
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public void GoShopping()
        {
            Console.WriteLine("Öğrenci veya müşteri farketmez, herkes alışverişe gider. ");
        }
    }

    class Customer:Person
    {
        public string CustomerNumber { get; set; }
    }

    class Student:Person
    {
        public string StudentNumber { get; set; }
        public string Department { get; set; }
    }
}
