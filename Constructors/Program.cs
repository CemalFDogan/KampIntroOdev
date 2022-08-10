using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Customer customer1 = new Customer() { Id = 1, FirstName = "Cemal Faruk", LastName ="Doğan", City="Malatya"  };

            //2
            Customer customer2 = new Customer(1, "Engin", "Demiroğ", "Ankara");


            Console.WriteLine(customer2.FirstName);
        }

        
    }

    class Customer
    {
        // default constructor ---> Biz herhangi bir class'ı new'lediğimiz zaman arkada default olarak
        // aşağıdakı blok bir kere çalışır. Biz eğer o bloğun içini doldurursak bizim doldurduğumuz biçimde çalışacaktır.

        public Customer()
        {
            /* 
             * Bu constructor ile overloading yapmış olduk. Bunu yapmamızın nedeni ise 
             * iki farklı oluşturma biçimini de aynı anda çalıştırmak istediğimizden dolayıdır.
             * Yukarıda Customer tipinde iki farklı nesne türettik. (customer1, customer2)
             * 
             * customer1 nesnesi türetirken default olarak oluşturuldu.
             * customer2 nesnesi türetirken parametreli olarak oluşturuldu.
             * 
             */
        }
        public Customer(int id, string firstName, string lastName, string city)                                       
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
