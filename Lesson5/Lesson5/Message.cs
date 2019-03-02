using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
     static class Message
    {

         public static void ShowMessageLessN(int n,string path)
        {
            string inputText = System.IO.File.ReadAllText(path);
            var str = inputText.Split(' ', ',', (char)13);

            foreach (var e in str)
            {
                if (e.Length<=n)
                {
                    Console.WriteLine(e);

                }

            }

        }

        public static void ShowOnlyNoCharEnding(char c, string path)
        {
            var inputText = System.IO.File.ReadAllText(path);
            var str = inputText.Split(' ', ',', (char)13);
            foreach (var e in str)
            {
                if (e[e.Length-1]!=c)
                {
                    Console.WriteLine(e);

                }
            }


        }

        public static void ShowLongestWord(string path)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(path);
            string tmp = sr.ReadToEnd();
            var str = tmp.Split(' ', ',', (char)13);

            string  a="1";
            foreach (var e in str)
            {
                if (a.Length<e.Length)
                {
                     a = e;

                }

            }
            Console.WriteLine(a);
            
            
        }

        public static void NewStringBuilder(string path)
        {
            var inputText = System.IO.File.ReadAllText(path);
            var textArr = inputText.Split(' ', ',',(char)13).OrderByDescending(e=>e.Length);
            //var tmp = textArr.ToList<string>().OrderByDescending(e=>e.Length);
            foreach (var e in textArr)
            {
                Console.Write($"   {e}   ");

            }
            
            StringBuilder strBld = new StringBuilder();
            
            
            
        }

        

    }
}
