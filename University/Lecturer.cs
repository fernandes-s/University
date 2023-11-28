using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Lecturer : Person
    {
        public string Module { get; set; }
        public double Salary { get; set; }

        public Lecturer(string fn, string sn, string eirC, string cy, int age, string ge, string ph, string ema, string mod, double sal)
            : base(fn, sn, eirC, cy, age, ge, ph, ema)
        {
            Module = mod;
            Salary = sal;
            
        }
    }
}
