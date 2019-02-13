using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        #region T1
        static double Min(double a, double b, double c)
        {
            if (a > b && a > c) return a;
            else return b > c ? b : c;

        }

        #endregion
        #region T2
        static void Count(int a)
        {
            Console.WriteLine(a.ToString().Length);
            Console.ReadKey();

        }
        #endregion

        static void Main(string[] args)
        {
          
            

           
        }
    }
}
