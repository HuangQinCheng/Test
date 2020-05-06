using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class ListExt
    {
        public static List<T> MyFindAll<T>(this List<T> lists, Func<T, bool> func)
        {
            List<T> result = new List<T>();
            foreach (var item in lists)
            {
                if (func(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
