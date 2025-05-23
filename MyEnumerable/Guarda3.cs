using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] items;

        public Guarda3()
        {
            items = new T[3];
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }
            return items[i];
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }
            items[i] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}