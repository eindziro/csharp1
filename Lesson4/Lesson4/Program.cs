using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {


        #region T1
        static void PairCount()
        {

        }
        #endregion
        static void Main(string[] args)
        {

            int[] arr = { 6, 2, 9, -3, 6 };
            StaticClass.PairCountProc(arr);
            Console.ReadKey();
        }

        static int[] ReadArr(string path)
        {
            string tmp;
            System.IO.File.ReadAllLines(path);
            int[] arr = {1,2 };
            return arr;
        }
        
    }
}
