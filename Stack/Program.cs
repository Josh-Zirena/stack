using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private ArrayList _list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot insert null into the list");

            Console.WriteLine("Adding: " + obj);
            _list.Add(obj);
        }


        public object Pop()
        {
            object lastElement;
            var lastElementIndex = _list.Count-1;

            if (lastElementIndex < 0)
                throw new InvalidOperationException("There are no elements to remove in the stack.");

            lastElement = _list[lastElementIndex];
            _list.RemoveAt(lastElementIndex);

            return lastElement;
        }


        public void Clear()
        {
            _list.Clear();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(3);
            stack.Push(2);
            stack.Push("Jack");

            Console.WriteLine("Remove: " + stack.Pop());
            Console.WriteLine("Remove: " + stack.Pop());
            Console.WriteLine("Remove: " + stack.Pop());
            Console.WriteLine("Remove: " + stack.Pop());

            stack.Push(3);
            stack.Push(2);
            stack.Push("Jack");

            stack.Clear();
            Console.WriteLine("Remove: " + stack.Pop());
        }
    }
}
