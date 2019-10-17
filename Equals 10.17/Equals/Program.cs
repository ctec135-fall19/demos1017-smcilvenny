using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc1 = new MyClass(123, "str1");
            MyClass mc2 = new MyClass(123, "str1");
            MyClass mc3 = new MyClass(234, "str3");

            if (mc1 == mc2) Console.WriteLine("mc1 = mc2");
            else Console.WriteLine("mc1 does not equal mc2");

            if (mc1.Equals(mc2)) Console.WriteLine("mc1 equals mc2");
            else Console.WriteLine("mc1 doesnt equal mc2");


            if (mc1.Equals(mc3)) Console.WriteLine("mc1 equals mc3");
            else Console.WriteLine("mc1 doesnt equal mc3");
        }
    }
}
