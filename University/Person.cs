using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    internal class Person 
    {

        public string FirstName { get; set; }   
        public string Surname { get; set; }
        public string EirCode { get; set; }
        public string County { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    public Person(string fn, string sn, string eirC, string cy, int age, string ge, string ph, string ema)
        {
            FirstName = fn;
            Surname = sn;
            EirCode = eirC;
            County = cy;
            Age = age;
            Phone = ph;
            Gender = ge;
            Email = ema;
        }
    }
}
