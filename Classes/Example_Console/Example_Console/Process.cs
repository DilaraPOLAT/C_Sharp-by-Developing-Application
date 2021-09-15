using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    class Process
    {
        public int sum(int value1,int value2)
        {
            int result = value1 + value2;
            Console.WriteLine("Result sum:"+result);
            return value1 + value2;
        }
        public int square(int x)
        {
            int result = x * x;
            Console.WriteLine("Result square:"+result);
            return result;
        }
    }
}
