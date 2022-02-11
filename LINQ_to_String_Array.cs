using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_Object
{
    class LINQ_to_String_Array
    {
        static void Main(string[] args)
        {
             
            string[] array = { "Vaishali", "Shalu", "Akshay", "Akki" };
         
            IEnumerable<string> result = from a in array
                                         where a.ToLowerInvariant().StartsWith("s")
                                         select a;
          
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
