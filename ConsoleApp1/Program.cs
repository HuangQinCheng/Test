
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>() { "1","2","3","4"};
            //var result = list.FindAll(str => str.CompareTo("1") > 0);
            var result = list.MyFindAll(str => str.CompareTo("1") > 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
