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
            for (int i = 0; i < arr.Length-1; i++)
            {
                PairCount += arr[i]%3 == 0 && arr[i+1] % 3!=0|| arr[i] % 3 != 0 && arr[i + 1] % 3 == 0 ? 1 : 0;     

            }
            Console.WriteLine(PairCount);

        }


    }
}
