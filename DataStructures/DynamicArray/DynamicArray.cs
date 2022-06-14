using System;

namespace DataStructures.DynamicArray
{
    public class DynamicArray<T> // List<T>
    {
            private const int DEFAULT_COUNT_ELEMENTS = 4;//элементы подсчета по умолчанию

            public int Count
            {
                get
                {
                    return _nextIndex;
                }
            }
            private T[] _elements;
            private int _nextIndex;
    

            public DynamicArray()
            {
                _elements = new T[DEFAULT_COUNT_ELEMENTS];// будет создаваться массив под 4 элемента
            }

            public void Add(T value)//метод добавления элемента
            {
                if (_nextIndex == _elements.Length)// если _nextIndex стал указываеть на элемент, индекс которого не существует,
                    // т.е. индекс которого равен длине массива
                {
                    Array.Resize(ref _elements, _elements.Length * 2);//увеличиваем размер массива
                }
                _elements[_nextIndex] = value;
                _nextIndex++;
            }

            public T Get(int index)// метод получения элемента
            {
                return _elements[index];
            }

            public void Delete(int index)//метод удаления элемента
            {
                if (index < Count && index > 0)
                {
                    for (int i = index; i < Count; i++)
                    {
                        _elements[i] = _elements[i + 1];
                    }

                    _nextIndex--;
                }
            }
        }
    }
