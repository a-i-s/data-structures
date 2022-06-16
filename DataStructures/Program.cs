using System;
using DataStructures.DynamicArray;
using DataStructures.CircularBuffer;
using DataStructures.Queue;
using DataStructures.Heap;


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

            /*var p1 = new Person("Test", 10);
            var p2 = new Person("Test2", 10);
            var p3 = new Person("Test3", 10);
            var p4 = new Person("Test4", 10);
            var p5 = new Person("Test5", 10);
            var p6 = new Person("Test6", 10);
            var p7 = new Person("Test7", 10);*/

            var queue = new Queue<string>();// очередь
            //queue.Dequeue();// выдаст ошибку System.IndexOutOfRangeException: Индекс находился вне границ массива.

            
            queue.Enqueue("Привет");
            queue.Enqueue("Пока");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            var queue2 = new Queue<int>();

            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Enqueue(4);
            queue2.Enqueue(5);

            Console.WriteLine(queue2.Dequeue());
            Console.WriteLine(queue2.Dequeue());
            Console.WriteLine(queue2.Dequeue());
            Console.WriteLine(queue2.Dequeue());
            Console.WriteLine(queue2.Dequeue());
            
            Console.WriteLine("_______________");

            Heap<int> heap = new Heap<int>();// куча
            heap.Add(5);
            heap.Add(3);
            heap.Add(25);
            heap.Add(17);
            heap.Add(7);
            heap.Add(1);
            heap.Add(19);
            heap.Add(2);

            for (int i = 0; i < heap.Count; i++)
            {
                Console.WriteLine(heap.Get(i));
            }
            Console.WriteLine("_______________");
            Console.WriteLine("Max 1:" + heap.ExtractMaximum());
            Console.WriteLine("Max 2:" + heap.ExtractMaximum());
            Console.WriteLine("Max 3:" + heap.ExtractMaximum());
            Console.WriteLine("Max 4:" + heap.ExtractMaximum());
        }
    }
}



