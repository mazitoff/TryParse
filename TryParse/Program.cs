using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static bool TryParse(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] < 47 || (int)str[i] > 58)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            bool res = TryParse(Console.ReadLine());
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
