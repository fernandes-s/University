using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student : Person
    {
        public string course {  get; set; }
        public string module { get; set; }

        public Student(string fn, string sn, string eirC, string cy, int age, string ge, string ph, string ema, string cour, string mod)
            :base(fn, sn, eirC, cy, age, ge, ph, ema)
        {
            course = cour;
            module = mod;
        }

    }
}
