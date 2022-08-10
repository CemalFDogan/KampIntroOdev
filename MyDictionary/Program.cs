using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakaVeSehirler1 = new Dictionary<int, string>();
            plakaVeSehirler1.Add(44,"Malatya");
            
            foreach (var pvs in plakaVeSehirler1)
            {
                Console.WriteLine();                
                Console.WriteLine($"{pvs.Value} : {pvs.Key}");
                Console.WriteLine();
                Console.WriteLine("-------------------------MyDictionary---------------------------------");
            }

            // -------------------------MyDictionary---------------------------------

            MyDictionary<string, string> plakaVeSehirler2 = new MyDictionary<string, string>();
            plakaVeSehirler2.Add("09", "Aydın");
            plakaVeSehirler2.Add("44", "Malatya");
            plakaVeSehirler2.Add("35", "İzmir");

            Console.WriteLine(plakaVeSehirler2.Count);
            Console.WriteLine();
            plakaVeSehirler2.ShowList();

        }
    }

    class MyDictionary<T,K>
    {
        KeyValuePair<T,K>[] items;
        KeyValuePair<T, K>[] tempItems;

        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }     
        public void Add(T key, K value)
        {
            tempItems = items;
            items = new KeyValuePair<T, K>[items.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] =  new KeyValuePair<T,K>(key, value);
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }

        
        public int Count
        {
            get { return items.Length; }            
        }

    }

    
}
