using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] items;
        private int count;

        public Guarda3()
        {
            items = new T[3];
            count = 0;
        }

        public void Add(T item)
        {
            if (count < 3)
            {
                items[count] = item;
                count++;
            }
        }

        public T GetItem(int i)
        {
            if (i < 0 || i >= count)
            {
                throw new IndexOutOfRangeException();
            }
            return items[i];
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i >= count)
            {
                throw new IndexOutOfRangeException();
            }
            items[i] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(params T[] newItems)
        {
            foreach (T item in newItems)
            {
                Add(item);
            }
        }
    }
}