using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Person
    {

        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string fn, string sn, string addr, string cy, int age, string ph, string ema)
        {
            Name = fn;
            Surname = sn;
            Address = addr;
            County = cy;
            Age = age;
            Phone = ph;
            Email = ema;
        }
    }
}
