using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0601_Ex03ListyIterator
{
    class ListyIterator<T> : IIterateList, IEnumerable<T>
    {
        private readonly List<T> list;

        public ListyIterator(IEnumerable<T> collection)
        {
            this.CurrentIndex = 0;
            list = new List<T>(collection);
        }

        public bool HasNext()
        {
            if (this.CurrentIndex < list.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Move()
        {

            return ++this.CurrentIndex < list.Count;
        }
        private int CurrentIndex { get; set; }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[CurrentIndex]);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

