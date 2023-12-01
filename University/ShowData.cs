using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University
{
    public partial class ShowData : Form
    {

        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;

        public ShowData()
        {
            InitializeComponent();
        }
        

        private void ShowData_Load(object sender, EventArgs e)
        {
            cboShowGender.DataSource = Enum.GetValues(typeof(Gender));
            cboShowCy.DataSource = Enum.GetValues(typeof(Counties));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowLecturers_Click(object sender, EventArgs e)
        {
            Usp("uspAllLecturer");
        }

        private void btnShowStu_Click(object sender, EventArgs e)
        {
            Usp("uspAllStudent");

        }

       

        private void cboShowGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cboShowGender.SelectedItem?.ToString();
            //if (cboShowGender.SelectedIndex.Equals(1))
            //{
            //    GeChoice("uspGenStudent");
            //}
            if (cboShowGender.SelectedIndex.Equals(1))
            {
                GeChoice("uspGenLecturer");
            }
            if (cboShowGender.SelectedIndex.Equals(2))
            {
                GeChoice("uspGenLecturer");
            }
            

        }

        
        private void rdb18to40_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspStudentAge18");
        }

        private void rdo31to49_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspStudentAge31");

        }

        private void rdo50over_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspStudentAge50");

        }

        private void rdoUnder50k_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspLecturerSalUnder50");
        }

        private void rdo50to100k_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspLecturerSalBet50to100");
        }

        private void rdoOver100k_CheckedChanged(object sender, EventArgs e)
        {
            Usp("uspLecturerSalOver100");
        }

        public string GeChoice(string procedureName)
        {

            //have a look at fluid gender 
            //needs to show up

            string ge = cboShowGender.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ge", ge);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
            return ge;

        }

        void Usp (string procedureName)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }


    }
}
