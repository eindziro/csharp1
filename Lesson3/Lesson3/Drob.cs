using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson3
{


    class Drob

    {
        /// <summary>
        /// Создание рационального числа
        /// </summary>
        /// <param name="a"> Числитель дроби</param>
        /// <param name="b">Знаменатель дроби</param>
        public Drob(int a, int b)
        {
            try
            {
                this.a = a;
                this.b = b;
                this.c = a / b;

            }
            catch(Exception)
            {

                Console.WriteLine("Знаменатель не может быть равен 0");
                Console.ReadKey();
            }
            

        }

        int a;

        int b;

        double c;

        public int A {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B { get { return b; } set { b = value; } }

        public double C { get { return this.c; } private set { } }


        public Drob Plus(Drob d2)
        {
            Drob d3=new Drob(1,1);
            if (b == d2.b)
            {
                d3.b = b;
                d3.a = a + d2.a;

            }
            else
            {
                d2.a *= b;
                a *= d2.b;
                b *= d2.b;
               

                d3.b = b;
                d3.a = a + d2.a;

            }
            return d3;
        }

        public Drob Minus(Drob d2)
        {
            Drob d3 = new Drob(1, 1);
            if (b == d2.b)
            {
                d3.b = b;
                d3.a = a - d2.a;

            }
            else
            {
                d2.a *= b;
                a *= d2.b;
                b *= d2.b;


                d3.b = b;
                d3.a = a - d2.a;

            }
            return d3;
        }

        public Drob Mult(Drob d2)
        {
            Drob d3 = new Drob(1, 1);
            d3.a = a * d2.a;
            d3.b = b * d2.b;

            return d3;

        }

        public Drob Divide(Drob d2)
        {
            Drob d3 = new Drob(1, 1);
            d3.a = a * d2.b;
            d3.b = b * d2.a;

            return d3;

        }

        public void Easy(ref Drob a)
        {
            int tmp = 1;
            int max = a.a >= a.b ? a.a : a.b;
            int min = a.a <= a.b ? a.a : a.b;

            while (tmp!=0)
            {

                tmp = max % min;
                max = min;
                if (tmp != 0) min = tmp;            
            }

            a.a =a.a/min;
            a.b /= min;
           

        }





    }
}
