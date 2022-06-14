namespace DataStructures.CircularBuffer
{
    public class CircularBuffer<T>// циклический массив
    {
        public int Count
        {
            get
            {
                return _nextIndex > _elements.Length ? _elements.Length : _nextIndex;// когда количество элементов перевалило
                // за длину массива, мы перезаписываем элементы, начиная с первого, но их общее количество остается неизменным
            }
        }
        
        private T[] _elements;
        private int _nextIndex;


        public CircularBuffer(int count)
        {
            _elements = new T[count];
        }
        
        public void Add(T value)// при добавлении следующего элемента, должны перемещаться в начало
        {
            var currentIndex = _nextIndex % _elements.Length;// берем _nextIndex по модулю
            _elements[currentIndex] = value;
            ++_nextIndex;
        }

        public T Get(int index)
        {
            if (_nextIndex < _elements.Length)
            {
                return _elements[index];
            }
            return _elements[(_nextIndex + index) % _elements.Length];
        }
        
    }
}