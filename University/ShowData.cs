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
        public ShowData()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;
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
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspAllLecturer";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        private void btnShowStu_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspAllStudent";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        void LoadData()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        private void cboShowGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string ge = cboShowGender.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();
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



        public string GeChoice(string procedureName)
        {
            string ge = cboShowGender.SelectedItem.ToString();

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
    }
}
