using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("qwer12aa", "qwer12");
            Console.WriteLine(acc.Check());
            Console.WriteLine(acc.CheckRegex());

            Console.ReadKey();
        }
    }
}
