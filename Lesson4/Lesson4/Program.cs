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

            int[] arr = { 6, 2, 9, -3, 6 };
            StaticClass.PairCountProc(arr);
            
            string qpath = @"D:\GeekBrains\Trash\q.txt";



            int[] tmp;
            tmp = StaticClass.ReadTXT(qpath);
            StaticClass.PairCountProc(tmp);
            //Console.WriteLine(System.IO.File.Exists(qpath));
            Console.ReadKey();
        }

        
        
    }
}
