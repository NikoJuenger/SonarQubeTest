using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            a = 1;
            b = 5;
            result = Addition(a, b);
                
        }
        static int Addition(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }
    }
    
}
