using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student : Person
    {
        DAO d = new DAO();
        public string course {  get; set; }
        public string module { get; set; }

        public Student(string fn, string sn, string eirC, string cy, string age, string ge, string ph, string ema, string cour, string mod)
            :base(fn, sn, eirC, cy, age, ge, ph, ema)
        {
            course = cour;
            module = mod;
        }

        public void AddNewStudent(string fn, string sn, string eirC, string cy, string age, string ge, string ph, string ema, string cour, string mod)
        {
            SqlCommand cmd = d.OpenCon().CreateCommand();
            cmd.CommandText = "uspAddStudent";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@eirC", eirC);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@ema", ema);
            cmd.Parameters.AddWithValue("@cour", cour);
            cmd.Parameters.AddWithValue("@mod", mod);



            cmd.ExecuteNonQuery();
            d.CloseCon();
        }


    }
}
