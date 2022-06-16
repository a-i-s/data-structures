using System.Collections.Generic;

namespace DataStructures.Heap
{
    public class Heap
    {
        public int Count => _heapData.Count;
        private List<int> _heapData = new List<int>();

        public void Add(int value)
        {
            _heapData.Add(value);// добавляем элемент в конец массива
            ShiftUp(_heapData.Count - 1);// индекс последнего элемента
        }

        public int Get(int index)// метод получения элемента
        {
            return _heapData[index];
        }

        private void ShiftUp(int index) //метод поднять наверх
        {
            int parentIndex = (index - 1) / 2;
            var currentElement = _heapData[index];//наш текущий элемент
            var parentElement = _heapData[parentIndex];// родительский элемент
            if (currentElement > parentElement)
            {
                Swap(_heapData, index, parentIndex); 
                ShiftUp(parentIndex);// используем рекурсию для просеивания элемента под индексом parentIndex
            }
        }

        private void ShiftDown(int index)// метод опустить вниз
        {
            // сравниваем левый и правый потомки
            // свапаем максимальный с нашим текущим (если этот максимальный юольше текущего )
            var leftChildIndex = index * 2 + 1;
            var rightChildIndex = index * 2 + 2;
            if (leftChildIndex >= _heapData.Count)// проверяем есть ли левый потомок,
                                                  // если его нет в массиве - то просеивание заканчиваем
            {
                return;
            }
            // по умолчанию принимаем, что индекс максимального потомок = индексу левого потомку
            var maxChildIndex = leftChildIndex;
            // если правый топомок есть и он оказался больше, чем левый
            if ((rightChildIndex < _heapData.Count) && (_heapData[leftChildIndex] < _heapData[rightChildIndex]))
            {
                // тогда пометим как индекс максимального потомка - индекс правого потомка
                maxChildIndex = rightChildIndex;
            }
            
            // если наш элемент оказался УЖЕ больше, чем наш максимальный топомок, то просеивание заканчиваем
            if (_heapData[index] > _heapData[maxChildIndex])
            {
                return;
            }
            
            Swap(_heapData, index, maxChildIndex);
            ShiftDown(maxChildIndex);// используем рекурсию для просеивания элемента под индексом maxChildIndex

        }

        private void Swap(List<int> array, int leftIndex, int rightIndex)//меняем элементы местами
        {
            var tempElement = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = tempElement;
        }

        public int ExtractMaximum()// метод удаления максимального элемента
        {
            var result = _heapData[0];// максимальный элемент кладем в переменную
            _heapData[0] = _heapData[_heapData.Count - 1];// последний элемент ставим на место первого
            //_heapData.Count - 1 можно заменить знаком ^(означает последний элемент с конца)
            ShiftDown(0);// просеиваем нулевой элемент

            return result;
        }
    }
}