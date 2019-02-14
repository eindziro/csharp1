using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Drob drob = new Drob(1,1);

            Drob drob2= drob.Mult(new Drob(4, 2));
            Console.WriteLine($"Mult {drob.Mult(new Drob(4, 2)).A} / {drob.Mult(new Drob(4, 2)).B}");

            Drob drob3 = drob2.Divide(new Drob(4, 2));
            Console.WriteLine($"Divide {drob3.A} / {drob3.B}");

            Drob drob4 = drob3.Plus(new Drob(1, 2));

            Drob drob5 = drob4.Minus(new Drob(1, 1));


            drob.Easy(ref drob5);
            Console.WriteLine($"{drob5.A} / {drob5.B}");
            Console.ReadKey();
        }
    }
}
