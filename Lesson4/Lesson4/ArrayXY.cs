using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class ArrayXY
    {
        private int[,] array;
        Random rand = new Random();
        List<int> tmp = new List<int>();

        public int[,] Array { get { return array; } private set { } }

        public int Max { get { return FindMax(); } set { } }

        public int Min { get { return FindMin(); } set { } }


        public ArrayXY(int x, int y)
        {
            this.array = new int[x, y];
            for (int i = 0; i < x - 1; i++)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    array[i, j] = rand.Next(0, 10);

                }

            }

        }



        public int Sum()
        {
            int sum = 0;
            foreach (int e in array)
            {
                sum += e;

            }
            return sum;

        }

        public int Sum(int min)
        {
            int sum = 0;

            foreach (int e in array)
            {

                if (e >= min) sum += e;

            }
            return sum;

        }

        public int FindMax()
        {
            int max = array[0, 0];
            foreach (int e in array)
            {
                if (max < e) max = e;


            }
            return max;

        }

        public int FindMin()
        {
            int min = array[0, 0];
            foreach (int e in array)
            {
                if (min > e) min = e;

            }
            return min;

        }

        public int[] FindMaxIndex()
        {
            int[] index = new int[2];
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }

                }

            }

            return index;

        }

    }


}
