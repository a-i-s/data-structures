using System;

namespace DataStructures.Queue
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age);
        }
    }

    public class Queue// очередь
    {
        private const int DEFAULT_COUNT_ELEMENTS = 3;
        
        private int _nextIndex;
        private int _headIndex;
        
        private Person[] _elements;

        public Queue()
        {
            _elements = new Person[DEFAULT_COUNT_ELEMENTS];
        }

        public void Enqueue(Person value)// метод добавления объекта в конец очереди
        {
            //if (_count > 0 && _nextIndex % _elements.Length == _headIndex % _elements.Length)//_nextIndex отвечает 
            //за общее количество элементов, значит если он больше 0, то хоть один элемент был добавлен;
            //_nextIndex % _elements.Length - отвечает за индекс в массиве, если эта величина равна голове, то голову
            //тоже необходимо передвинуть
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
            var newArray = new Person[_elements.Length * 2]; //создали новый массив большего размера
            for (int i = 0; i < _elements.Length; i++) // копируем все элементы
            {
                newArray[i] = _elements[(_headIndex + i) % _elements.Length];
            }

            _headIndex = 0;
            _nextIndex = _elements.Length;
            _elements = newArray;
        }

        public Person Dequeue()// метод удаления первого объекта из очереди 
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

        public Person Peak()// метод возвращения первого объекта из очереди 
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