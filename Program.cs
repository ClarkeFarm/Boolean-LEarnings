using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bools
{
    class Program
    {
        static void Main(string[] args)
        {
            string pT = "abc123";
            string pA = "abc123";
            int logAttempt = 3;
            int logMax = 5;


            bool pizzaTime = (pT == pA && logAttempt < logMax);

            Console.WriteLine(pizzaTime);
            Console.ReadKey();
        }
    }
}