using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_operator
{

    using System;
    public class Demo
    {
        public static void Main()
        {
            object[] obj = new object[2];
            obj[0] = "jack";
            obj[1] = 32;
            for (int i = 0; i < obj.Length; ++i)
            {
                string s = obj[i] as string;
                Console.Write("{0}: ", i);
                if (s != null)
                    Console.WriteLine("'" + s + "'");
                else
                    Console.WriteLine("This is not a string!");
            }
            Console.ReadKey();
        }
    }
}