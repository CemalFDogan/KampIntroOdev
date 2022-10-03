using System;

namespace Delegates
{
    internal class Program
    {
        // Bu delelege void olan ve parametre almayan metodlar için kullanılan bir operasyondur.
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            
            MyDelegate3 myDelegate3 = matematik.Add;
            myDelegate3 += matematik.Multiply; // Burada sonucu 6 olarak döndürecektir. Yani delegeye en son verilen görev döner.
            var result = myDelegate3(2,3);
            Console.WriteLine(result);

            myDelegate2("Hello");
            myDelegate();

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    
    public class Matematik
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }

}
