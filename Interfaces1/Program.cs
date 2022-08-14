using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface new'lenemez
            // IPersonManager personManager = new IPersonManager(); ---> Hatalı
            IPersonManager customerManager = new CustomerManager();
           // customerManager.Add();
            
            IPersonManager employeeManager = new EmployeeManager();
            // employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //Unimplemented operation 
        //Burada sadece imza bulunur.
        void Add();
        void Update();
    }
    class PersonManager
    {
        //İmplemented operation - İçi doldurulmuş, tamamlanmış operasyon
        public void Add()
        {
            Console.WriteLine("Eklendi.");
        }
    }
    //-------------------------------------------------------------------------
    // inherits---> class               implements---> İnterface
    // extends ---> Java'da
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Peronel güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            // Stajer ekleme kodları
            Console.WriteLine("Stajer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajer güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
