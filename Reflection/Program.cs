using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        /* 
         * Reflection --> Uygulama çalısırken herhangi bir nesnenin hakkında bilgi toplayabilir ve hatta
         * bu nesneyi istediğiniz zaman bir metodunu çalıştırabilirsiniz.
         * 
         * Bilgi almak derken;
         * Customer diye bir nesnemiz var ve bu nesnenin özellkleri, attributes'ları var mı?
         * Bunların değerleri nelerdir? , isimleri nelerdir?, Parametreleri nelerdir? ....
         * 
         * Yine çalışma anında kullanıcının ekrana girdiği değerlere göre bir sorgu oluşturmamız gerekebilir.
         * Yani dinamik olarak veritabınına sorgu atabiliriz.
         */


        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Add2());
            //Console.WriteLine(dortIslem.Add(3, 4));

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 6, 7); // Activator.CreateInstance() aslında obje döndürür.
            //Console.WriteLine(dortIslem.Add(4,5));
            //Console.WriteLine(dortIslem.Add2());

            // Bazen çalıştırmak istediğimiz işlemin adını felan bilemeyebiliriz ve durumda;

            var instance = Activator.CreateInstance(type, 6, 7);

            MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
            
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------------------------------");
            Console.WriteLine();

            var metods = type.GetMethods();
            foreach (var info in metods)
            {
                Console.WriteLine("Metod adı : {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                                    
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _number1;
        private int _number2;

        public DortIslem(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public DortIslem()
        {

        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add2()
        {
            return _number1 + _number2;
        }

        [MetodName("Carpma")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
        
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
