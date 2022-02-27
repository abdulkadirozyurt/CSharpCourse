using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Elma", 50);
            myDictionary.Add("Armut", 30);

            Console.WriteLine(myDictionary.Count);
        }
    }
}
