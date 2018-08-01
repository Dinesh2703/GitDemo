using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class op
    {
         public int sum(int x, int y)
        {
            return x + y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            op m = new op();

            Console.WriteLine("sum is" + m.sum(x, y));
            Console.WriteLine("sum is" + m.mul(x, y));
            Console.ReadKey();
        }
    }
}
