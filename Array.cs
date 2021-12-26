using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 100, 101, 110 };
            int len = arr.Length;
            Console.WriteLine("Length of Array" + len);
            Console.WriteLine(arr[0] + "" + arr[4]);
        }
    }
}