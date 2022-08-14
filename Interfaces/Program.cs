using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // IPerson person = IPerson();  ---> Bu şekilde bir intance oluşturamam ama aşağıdaki örnekteki
            //                                   gibi oluşturabilirim.

            IPerson person1 = new Customer();
            // ya da
            IPerson person2 = new Student();


            CustomerManager customerManager = new CustomerManager();

            // customerManager.Add(new SqlServerCustomerDal());            // Yanda interface aracılığıyla iki farklı işlemi 
            // customerManager.Add(new OracleServerCustomerDal());         // tek seferde yapabildik.

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { 
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            



            Console.ReadLine();
        }
    }
    
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
