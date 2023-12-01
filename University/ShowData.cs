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
            cboShowGenderStu.DataSource = Enum.GetValues(typeof(Gender));
            cboShowCy.DataSource = Enum.GetValues(typeof(Counties));
            cboShowCyStu.DataSource = Enum.GetValues(typeof (Counties));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowLecturers_Click(object sender, EventArgs e)
        {
            UspLec("uspAllLecturer");
        }

        private void btnShowStu_Click(object sender, EventArgs e)
        {
            UspStu("uspAllStudent");

        }       

        private void cboShowGender_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cboShowGender.SelectedIndex.Equals(1))
            {
                GeChoiceLec("uspGenLecturer");
            }
            if (cboShowGender.SelectedIndex.Equals(2))
            {
                GeChoiceLec("uspGenLecturer");
            }
        }

        private void cboShowGenderStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShowGender.SelectedIndex.Equals(1))
            {
                GeChoiceStu("uspGenStudent");
            }
            if (cboShowGender.SelectedIndex.Equals(2))
            {
                GeChoiceStu("uspGenStudent");
            }
        }


        private void rdb18to40_CheckedChanged(object sender, EventArgs e)
        {
            UspStu("uspStudentAge18");
        }

        private void rdo31to49_CheckedChanged(object sender, EventArgs e)
        {
            UspStu("uspStudentAge31");

        }

        private void rdo50over_CheckedChanged(object sender, EventArgs e)
        {
            UspStu("uspStudentAge50");

        }

        private void rdoUnder50k_CheckedChanged(object sender, EventArgs e)
        {
            UspLec("uspLecturerSalUnder50");
        }

        private void rdo50to100k_CheckedChanged(object sender, EventArgs e)
        {
            UspLec("uspLecturerSalBet50to100");
        }

        private void rdoOver100k_CheckedChanged(object sender, EventArgs e)
        {
            UspLec("uspLecturerSalOver100");
        }

        private void cboShowCy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CyChoiceLec("uspLecturerCy");
        }

        private void cboShowCyStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CyChoiceStu("uspStudentCy");
        }
        public string GeChoiceLec(string procedureName)
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
            dgvLecturer.DataSource = dt;
            dao.CloseCon();
            return ge;
        }

        public string GeChoiceStu(string procedureName)
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
            dgvStudent.DataSource = dt;
            dao.CloseCon();
            return ge;
        }


        public string CyChoiceLec(string procedureName)
        {
            string cy = cboShowCy.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cy", cy);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvLecturer.DataSource = dt;
            dao.CloseCon();
            return cy;
        }
        public string CyChoiceStu(string procedureName)
        {
            string cy = cboShowCyStu.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cy", cy);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvStudent.DataSource = dt;
            dao.CloseCon();
            return cy;
        }


        void UspStu (string procedureName)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvStudent.DataSource = dt;
            dao.CloseCon();
        }

        void UspLec(string procedureName)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvLecturer.DataSource = dt;
            dao.CloseCon();
        }






    }
}
