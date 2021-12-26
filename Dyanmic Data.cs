using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;


class Demo
{
    dynamic Data = 66;
    public int Method(int X, int Y)
    {
        return (X + Y) * Data;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Demo Obj = new Demo();
        dynamic value1 = 5;
        dynamic value2 = 6;
        dynamic Str = "Your Result Is: ";
        Console.WriteLine(Str + Obj.Method(value1, value2));
        Console.ReadLine();
    }
}
