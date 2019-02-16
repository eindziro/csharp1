using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {

        
        static void Main(string[] args)
        {

            #region T2
            //int[] arr = { 6, 2, 9, -3, 6 };
            //StaticClass.PairCountProc(arr);

            //string qpath = @"D:\GeekBrains\Trash\q.txt";



            //int[] tmp;
            //tmp = StaticClass.ReadTXT(qpath);
            //StaticClass.PairCountProc(tmp);
            ////Console.WriteLine(System.IO.File.Exists(qpath));
            //Console.ReadKey();

            #endregion


            ArrayXY arr = new ArrayXY(3, 3);
            for (int i = 0; i < arr.Array.GetLength(0); i++)
            {
                for (int j = 0; j < arr.Array.GetLength(1); j++)
                {
                    Console.Write($" {arr.Array[i, j]} ");

                }
                Console.WriteLine();
            }
            Console.WriteLine($"SUM =  {arr.Sum()}");
            Console.WriteLine($"Sum >5 = {arr.Sum(5)}");

            int max, min;
            int[] index = { 0, 0 };

            max = arr.Max;
            min = arr.Min;
            index = arr.FindMaxIndex();
            Console.WriteLine("MAX = {0}   MIN = {1}    Index = {2},{3}", max, min, index[0], index[1]);


            ArrayXY tmp = new ArrayXY(@"D:\GeekBrains\Trash\q.txt");
            for (int i = 0; i < tmp.Array.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.Array.GetLength(1); j++)
                {
                    Console.Write($" {tmp.Array[i, j]} ");

                }
                Console.WriteLine();
            }

            tmp.WriteFile(@"D:\GeekBrains\Trash\output.txt");



            Console.ReadKey();



            
        }



    }
}
