using System;

namespace DataStructures.LinkedList
{
    /*public class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }*/

    public class Node<T>
    {
        public Node<T> Next;
        //public Node Previous;
        public T Value;

        public Node(T value)
        {
            Value = value;
        }
        public void Print()// метод вывода объекта на консоль
        {
            Console.WriteLine(Value);
        }
    }

    public class LinkedList<T>
    {
        public Node<T> Head = null; // Первый (головной) элемент списка
        public Node<T> Tail = null; // Крайний (хвостовой) элемент списка 

        public void AddLast(T data) // метод добавить данные в конец связанного списка
        {
            Node<T> node = new Node<T>(data); // создали ноду и передали туда значение
            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else // иначе tail был и нам надо его обновить
            {
                Tail.Next = node; // последнему элементу указали ссылку на следующий
                // в качестве нового добавленного
                Tail = node;
            }
        }

        public void AddFirst(T data) // метод добавления ноды в самое начало
        {
            Node<T> node = new Node<T>(data);
            if (Head == null) // означает, что элементов вообще еще не было
            {
                Head = node;
                Tail = node;
            }
            else // если элементы были 
            {
                node.Next = Head; // следующий элемент у node это текущий Head
                Head = node; // а Head перемещаем на нашу новую добавленную node
            }
        }

        public void Remove(T data) // метод удаления данных из связного списка
            // Выполняется удаление первого совпадения данных.
        {
            Node<T> previousNode = null; // сохранячем предыдущую node
            var currentNode = Head;
            // ищем node
            while (currentNode != null) // таким образом пробежим по всем node
            {
                // если текущая node, та самая искомая node, которую нужно найти
                if (currentNode.Value.Equals(data))
                {
                    RemoveNode(currentNode, previousNode);
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
        private void RemoveNode(Node<T> removingNode, Node<T> previousNode)
        {
            if (removingNode == Head)
            {
                Head = removingNode.Next; // перемещаем указатель Head
            }

            if (removingNode == Tail)
            {
                Tail = previousNode;
            }

            if (previousNode.Next != null)
            {
                previousNode.Next = removingNode.Next;
            }
        }

        public void PrintAll() // метод вывода всех объектов в консоль
        {
            if (Head == null)
            {
                return;
            }
            
            var currentNode = Head;
            while (currentNode != null)
            {
                currentNode.Print();
                currentNode = currentNode.Next;
            }
        }
    }
}