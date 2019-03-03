using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class People
    {

        public int a;
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Mark1 { get; set; }

        public int Mark2 { get; set; }

        public int Mark3 { get; set; }

        public double Marks { get { return (Mark1 + Mark2 + Mark3) / 3.0; } }

        public override string ToString()
        {
            return $"{Name} {Surname} : {Mark1}  {Mark2}  {Mark3}  {Marks.ToString("#.##")} ";
        }
    }
}
