using System;

namespace DataStructures.LinkedList
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
    }

    public class Node
    {
        public Node Next;
        //public Node Previous;
        public Person Value;

        public Node(Person value)
        {
            Value = value;
        }
        public void Print()// метод вывода объекта на консоль
        {
            Console.WriteLine("Name:" + Value.Name + "Age:" + Value.Age);
        }
    }

    public class LinkedList
    {
        public Node Head = null; // Первый (головной) элемент списка
        public Node Tail = null; // Крайний (хвостовой) элемент списка 

        public void AddLast(Person data) // метод добавить данные в  связный список
        {
            Node node = new Node(data); // создали ноду и передали туда значение
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

        public void AddFirst(Person data) // метод добавления ноды в самое начало
        {
            Node node = new Node(data);
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

        public void Remove(Person data) // метод удалкния данных из связного списка
            // Выполняется удаление первого совпадения данных.
        {
            Node previousNode = null; // сохранячем предыдущую node
            var currentNode = Head;
            // ищем node
            while (currentNode != null) // таким образом пробежим по всем node
            {
                // если текущая node, та самая искомая node, которую нужно найти
                if (currentNode.Value.Name == data.Name && currentNode.Value.Age == data.Age)
                {
                    RemoveNode(currentNode, previousNode);
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
        private void RemoveNode(Node removingNode, Node previousNode)
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