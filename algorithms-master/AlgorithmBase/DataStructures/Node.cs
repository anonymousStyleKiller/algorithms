using System;

namespace AlgorithmBase.DataStructures
{
    internal class Node<T> : IComparable
        where T : IComparable
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public int CompareTo(object obj)
        {
            var item = obj as Node<T>;
            if (item != null)
                return Data.CompareTo(item);
            throw new ArgumentException("Не совпадение типов");
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                    Left = node;
                else
                    Left.Add(data);
            }
            else
            {
                if (Right == null)
                    Right = node;
                else
                    Right.Add(data);
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}