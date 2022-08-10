using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, boolean, enum vb. ---> value type (değer tip) 

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            Console.WriteLine("-------------------Array-----------------");
            // arrays, class, interface... ---> reference types

            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };


            sayilar1 = sayilar2;

            foreach (int sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            sayilar2[0] = 99;
            Console.WriteLine("-------------");

            foreach (int sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("sayilar1[0] :" + sayilar1[0]);

            Console.WriteLine("-------------------Class-----------------");


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person2.FirstName = "Derin";
            //Console.WriteLine(person1.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";
            

            Employee employee = new Employee();
            employee.FirstName = "Cemal";

            Person person3 = customer;
            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
                                                    // Burada Add() metoduna customer ve employee de yazsam sıkıntı çıkmauacaktır. Çünkü bu class'lar inheritance yolu
                                                   // Person class'ına bağlıdır. 

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    // base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
