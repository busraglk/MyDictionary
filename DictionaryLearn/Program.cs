using System;
using System.Collections.Generic;

namespace DictionaryLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey,TValue>
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Büşra");
            myDictionary.Add(2, "Barış");
            myDictionary.Add(3, "Ahsen");
            myDictionary.Add(4, "Behlül");
            myDictionary.Add(5, "Özge");
            Console.WriteLine(myDictionary.Count);

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(10, "Gök");
            myDictionary2.Add(11, "Önçal");
            myDictionary2.Add(12, "Kuru");
            Console.WriteLine(myDictionary2.Count);


            Console.ReadLine();
        }
    }
}
