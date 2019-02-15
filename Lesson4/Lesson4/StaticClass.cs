using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class StaticClass
    {



        public static void PairCountProc(int[] arr)
        {
            int PairCount = 0; ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                PairCount += arr[i] % 3 == 0 && arr[i + 1] % 3 != 0 || arr[i] % 3 != 0 && arr[i + 1] % 3 == 0 ? 1 : 0;

            }
            Console.WriteLine(PairCount);

        }

        public static int[] ReadTXT(string path )
        {
            int[] a;
            string[] tmp = System.IO.File.ReadAllLines(path);

            a = new int[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                a[i] = int.Parse(tmp[i]);

            }
            return a;
        }

        public static void ArrFromFile(string path)
        {
            if (System.IO.File.Exists(path))
            {
                ReadTXT(path);

            }
            else
            {
                Console.WriteLine("File Load Error");
            }
        }


    }
}
