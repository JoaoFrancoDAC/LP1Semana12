using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T item1;
        private T item2;
        private T item3;

        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    return item1;
                case 1:
                    return item2;
                case 2:
                    return item3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    item1 = item;
                    break;
                case 1:
                    item2 = item;
                    break;
                case 2:
                    item3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}