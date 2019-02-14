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
        #region T5
        static void SimpleNumberCount(int a)
        {
            string str = a.ToString();
            int sum = 0;
            foreach (var e in str)
            {
                sum += int.Parse(e.ToString());


            }

            bool b = (a % sum == 0);
            Console.WriteLine(b);
            Console.ReadKey();

        }
        static void SimpleNumberCount(int min, int max)
        {
            int Count = 0;
            DateTime start = DateTime.Now;

            for (int i = min; i < max + 1; i++)
            {
                string str = i.ToString();
                int sum = 0;

                foreach (var e in str)
                {
                    sum += int.Parse(e.ToString());
                }

                if (i % sum == 0) Count++;
            }
            DateTime finish = DateTime.Now;

            Console.WriteLine(Count);
            Console.WriteLine((finish - start).Milliseconds);
            Console.ReadKey();

        }

        #endregion
        #region T6
        static void NumBetweenRec(int min, int max)
        {
            if (min == max) Console.WriteLine(max);
            else
            {
                Console.WriteLine(min);
                NumBetweenRec(min + 1, max);
            }
        }

        static int SumRec(int min, int max)
        {
            if (min == max) return max;
            else
            {
                
                return min + SumRec(min + 1, max);

            }
            

        }
        #endregion

        static void Main(string[] args)
        {
            //SimpleNumberCount(24);
            //SimpleNumberCount(1, 1000000);
            //NumBetweenRec(1, 10);
            //Console.WriteLine(SumRec(1, 5));
            Console.ReadKey();




        }
    }
}
