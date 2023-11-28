using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace University
{
    internal class AddPeople : DAO
    {

        public void AddNewLecturer(string fn, string sn, string eirC, string cy, string age, string ge, string ph, string ema, string dept, float pay)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddLecturer";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@eirC", eirC);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@ema", ema); 
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@pay", pay);



            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNewStudent(string fn, string sn, string eirC, string cy, string age, string ge, string ph, string ema, string dept, float pay)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddLecturer";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@eirC", eirC);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@ema", ema);
            //cmd.Parameters.AddWithValue("@dept", dept);
            //cmd.Parameters.AddWithValue("@pay", pay);



            cmd.ExecuteNonQuery();
            CloseCon();
        }

    }
    
}
