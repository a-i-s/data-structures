using System;
using DataStructures.DynamicArray;
using DataStructures.CircularBuffer;

namespace DataStructures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> list = new DynamicArray<int>();// динамический массив
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
            Console.WriteLine("_______________");

            var circularBuffer = new CircularBuffer<int>(3);// циклический массив
            
            circularBuffer.Add(5);
            circularBuffer.Add(10);
            circularBuffer.Add(20);
            circularBuffer.Add(30);
            circularBuffer.Add(40);

            for (int i = 0; i < circularBuffer.Count; i++)
            {
                Console.WriteLine(circularBuffer.Get(i));// выведутся последние три элемента массива
            }
            
        }
    }
}



