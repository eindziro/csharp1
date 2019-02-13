using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {

        static void Anketa()
        {
            string name, surname;
            int age;
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Surname:");
            surname = Console.ReadLine();
            Console.WriteLine("age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " " + surname + " " +age);
            Console.WriteLine($"{name} {surname} {age}");
            Console.WriteLine("{0} {1} {2}", name, surname,age);

            string format = String.Format("{0} {1} {2}", name, surname, age);
            Console.WriteLine(format);

            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            Anketa();

           


        }
    }
}
