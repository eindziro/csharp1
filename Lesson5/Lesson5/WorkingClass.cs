using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class WorkingClass
    {
        List<People> Class;

        /// <summary>
        /// Класс для обработки данных класса People
        /// </summary>
        /// <param name="Args"></param>
        public WorkingClass(params People[] Args)
        {
            Class = new List<People>();

            foreach (var item in Args)
            {
                Class.Add(item);

            }
            Sort();

        }

        private void Sort()
        {

            Class = Class.OrderBy(e => e.Marks).ToList();
        } 


        public List<People> Worst()
        {
            List<People> tmp = new List<People>();
            int k = 0;
            while (k<2||Class[k].Marks ==Class[2].Marks)
            {
                Console.WriteLine(Class[k++]);

            }

            return tmp;

        }
    }
}
