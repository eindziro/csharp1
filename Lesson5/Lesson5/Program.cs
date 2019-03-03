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
            #region T1
            //Account acc = new Account("qwer12aa", "qwer12");
            //Console.WriteLine(acc.Check());
            //Console.WriteLine(acc.CheckRegex());

            //Console.ReadKey();

            #endregion

            #region T2

            string path = @"D:\GeekBrains\Geekbrains_HW\С#1_Sergey\csharp1\q.txt";
            //Message.ShowMessageLessN(7, path);
            //Message.ShowOnlyNoCharEnding('y', path);
            //Message.ShowLongestWord(path);\
            //Message.NewStringBuilder(path);


            #endregion

            #region T3

            //string a = "abcd";
            //string b = "dcba";
            //Console.WriteLine(a.OrderBy(e => e).SequenceEqual(b.OrderBy(e=>e)));
            //Console.ReadKey();
            Random rand = new Random();
            WorkingClass workingClass = new WorkingClass
                (
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) },
                new People() { Name = $"Ivan", Surname = "Ivanov", Mark1 = rand.Next(5), Mark2 = rand.Next(5), Mark3 = rand.Next(5) }

                );
            workingClass.Worst();
            Console.ReadKey();

            #endregion

        }
    }
}
