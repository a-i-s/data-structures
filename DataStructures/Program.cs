using System;
using DataStructures.DynamicArray;
using DataStructures.CircularBuffer;
using DataStructures.Queue;


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
            Console.WriteLine("_______________");

            var p1 = new Person("Test", 10);
            var p2 = new Person("Test2", 10);
            var p3 = new Person("Test3", 10);
            var p4 = new Person("Test4", 10);
            var p5 = new Person("Test5", 10);
            var p6 = new Person("Test6", 10);
            var p7 = new Person("Test7", 10);

            var queue = new Queue.Queue();// очередь
            //queue.Dequeue();// выдаст ошибку System.IndexOutOfRangeException: Индекс находился вне границ массива.

            
            queue.Enqueue(p1);
            queue.Enqueue(p2);
            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);

            queue.Enqueue(p3);
            queue.Enqueue(p4);
            queue.Enqueue(p5);
            queue.Enqueue(p6);
            queue.Enqueue(p7);

            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);
        }
    }
}



