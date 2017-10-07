using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public class MyStack<T>
    {
        private List<T> list = new List<T>();

        public void Push(T value)
        {
            list.Add(value);
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            T value = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return value;
        }
    }
}
