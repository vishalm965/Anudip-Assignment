using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_With_Object
{
    class LINQ_to_Strings
    {
        static void Main(string[] args)
        {
             
            string str1 = "Welcome to Java T Point.Com";
           
            var result = from s in str1.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
