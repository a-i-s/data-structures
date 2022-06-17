using System;

namespace DataStructures.Queue
{
   public class Queue<T>// очередь
    {
        private const int DEFAULT_COUNT_ELEMENTS = 3;
        
        private int _nextIndex;
        private int _headIndex;
        
        private T[] _elements;

        public Queue()
        {
            _elements = new T[DEFAULT_COUNT_ELEMENTS];
        }

        public void Enqueue(T value)// метод добавления объекта в конец очереди
        {
            if (_nextIndex - _headIndex >= _elements.Length)
            {
                ExtendQueue();
            }
            var currentIndex = _nextIndex % _elements.Length;
            _elements[currentIndex] = value;
            
            ++_nextIndex;
        }

        private void ExtendQueue()// метод расширения очереди
        {
            var newArray = new T[_elements.Length * 2]; //создали новый массив большего размера
            for (int i = 0; i < _elements.Length; i++) // копируем все элементы
            {
                newArray[i] = _elements[(_headIndex + i) % _elements.Length];
            }

            _headIndex = 0;
            _nextIndex = _elements.Length;
            _elements = newArray;
        }

        public T Dequeue()// метод удаления первого объекта из очереди 
        {
            if (_headIndex == _nextIndex)// все элементы уже достали, два указателя встретились (голова и хвост).
            // хвост - последний добавленный элемент, голова - первый добавленный элемент
            {
                throw new IndexOutOfRangeException(); 
            }
            
            var result = _elements[_headIndex % _elements.Length];//берем самый первый добавленный элемент по модулю
            ++_headIndex;// двигаем вперед
            return result;
        }

        public T Peak()// метод возвращения первого объекта из очереди 
        {
            if (_headIndex == _nextIndex)
            {
                throw new IndexOutOfRangeException(); 
            }
            // если элемент добавлен
            return _elements[_headIndex % _elements.Length];//берем самый первый добавленный элемент по модулю;
        }
    }
}