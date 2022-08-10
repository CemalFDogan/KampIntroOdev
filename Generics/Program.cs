using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            sehirler.Add("Malatya");
            sehirler.Add("Malatya");
            sehirler.Add("Malatya");

            Console.WriteLine(sehirler.Count);

            //-----------------------------------------------------
            
            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("Aydın");
            sehirler2.Add("Aydın");
            sehirler2.Add("Aydın");
            sehirler2.Add("Aydın");

            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> // Generic class
    {
        T[] items;
        T[] tempArray;

        public MyList()
        {
            items = new T[0];
            
        }
        public void Add(T item)
        {
            tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        
        public int Count
        {
            get { return items.Length; }            
        }

    }
}
