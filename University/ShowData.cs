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
            cboShowGenderLec.DataSource = Enum.GetValues(typeof(Gender));
            cboShowGenderStu.DataSource = Enum.GetValues(typeof(Gender));
            cboShowCy.DataSource = Enum.GetValues(typeof(Counties));
            cboShowCyStu.DataSource = Enum.GetValues(typeof(Counties));
            cboSortAgeStu.DataSource = Enum.GetValues(typeof(Sort));
            cboSortSalLec.DataSource = Enum.GetValues(typeof(Sort));
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
            if (cboShowGenderLec.SelectedIndex.Equals(1))
            {
                GeChoiceLec("uspGenLecturer");
            }
            else if (cboShowGenderLec.SelectedIndex.Equals(2))
            {
                GeChoiceLec("uspGenLecturer");
            }
            else if (cboShowGenderLec.SelectedIndex.Equals(3))
            {
                GeChoiceLec("uspGenLecturer");
            }
        }

        private void cboShowGenderStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShowGenderLec.SelectedIndex.Equals(1))
            {
                GeChoiceStu("uspGenStudent");
            }
            else if (cboShowGenderLec.SelectedIndex.Equals(2))
            {
                GeChoiceStu("uspGenStudent");
            }
            else if (cboShowGenderLec.SelectedIndex.Equals(3))
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

        private void cboSortAgeStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSortAgeStu.SelectedIndex.Equals(1))
            {
                SortStu("uspSortStudentAgeAsc");
            }
            else if (cboSortAgeStu.SelectedIndex.Equals(2))
            {
                SortStu("uspSortStudentAgeDesc");
            }
        }

        private void cboSortSalLec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSortSalLec.SelectedIndex.Equals(1))
            {
                SortLec("uspSortLecturerSalAsc");
            }
            else if (cboSortSalLec.SelectedIndex.Equals(2))
            {
                SortLec("uspSortLecturerSalDesc");
            }
        }


        //Methods under

        //Sort
        void SortStu(string procedureName)
        {
            string age = cboSortAgeStu.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("age", age);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvStudent.DataSource = dt;
            dao.CloseCon();

        }

        void SortLec(string procedureName)
        {
            //need to fix error for variable, mixing string and money

            //string sal = cboSortSalLec.SelectedItem.ToString();
            //da = new SqlDataAdapter();
            //dt = new DataTable();


            //SqlCommand cmd = dao.OpenCon().CreateCommand();
            //cmd.CommandText = procedureName;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("pay", sal);

            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //dgvStudent.DataSource = dt;
            //dao.CloseCon();
        }



        //Gender
        void GeChoiceLec(string procedureName)
        {
            string ge = cboShowGenderLec.SelectedItem.ToString();
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
        }

        void GeChoiceStu(string procedureName)
        {
            string ge = cboShowGenderStu.SelectedItem.ToString();
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
        }


        //County
        void CyChoiceLec(string procedureName)
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
        }

        void CyChoiceStu(string procedureName)
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
        }


        //Student
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

        //Lecturer
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
