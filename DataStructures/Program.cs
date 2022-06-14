using System;
using DataStructures.DynamicArray;

namespace DataStructures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> list = new DynamicArray<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.Get(i));
            }
            Console.WriteLine("_______________");
            
            list.Delete(2);
            
            for (int i = 0; i < list.Count; i++)
              {
                Console.WriteLine(list.Get(i));
              }
        }
    }
}



