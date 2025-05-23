using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T threshold) 
            where T : IComparable<T>
        {
            return items.Where(item => item.CompareTo(threshold) < 0);
        }
    }
}