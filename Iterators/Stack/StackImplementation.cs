using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class StackImplementation<T> : IEnumerable<T>
    {
        private readonly List<T> stack;
        private int currentIndex;
       // public int Count => currentIndex + 1;

        public StackImplementation(params T[] arr)
        {
            stack = arr.ToList();
            currentIndex = stack.Count - 1;
        }

        public void Push(params T[] values)
        {
            foreach (var item in values)
            {
                stack.Insert(++currentIndex, item);
            }
        }

        public void Pop()
        {

            if (stack.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            else
            {
               stack.RemoveAt(currentIndex--);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
