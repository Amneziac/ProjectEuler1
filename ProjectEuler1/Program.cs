using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> multiples = new List<int>();
            int total = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                    multiples.Add(i);
            }

            foreach (int m in multiples)
            {
                total += m;
            }

            Console.Write(total);
        }
    }
}
