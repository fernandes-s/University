using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace University
{
    public partial class AddLecturer : Form
    {

        public AddLecturer()
        {
            InitializeComponent();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboDpt.DataSource = Enum.GetValues(typeof(Department));

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string eirC = txtEirCode.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string age = lblAgeShow.Text;
            string ge = "Male";
            if (rdoFemale.Checked)
            {
                ge = "Female";
            }
            else if (rdoFluid.Checked)
            {
                ge = "Fluid";
            }
            string ph = txtPhone.Text;
            string ema = txtEmail.Text;
            string dept = cboDpt.SelectedItem.ToString();
            float pay = float.Parse(txtSal.Text);

            Lecturer l = new Lecturer(fn, sn,eirC, cy, age, ge, ph, ema, dept, pay);

            l.AddNewLecturer(fn, sn, eirC, cy, age, ge, ph, ema, dept, pay);
            MessageBox.Show("New Lecture Added to Database", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////message box has four parameters
            ////1 message
            ////2 title
            ////3 button
            //4 icon
            txtFn.Clear();
            txtSn.Clear();
            txtEirCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSal.Clear();




            string regEirCode = @"^[A-Za-z]\d{1,2}[A-Za-z0-9]{4}$";

            string regPhone = @"^\d{3}-\d{7}$";

            string regEmail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            //regEx phone checker
            if (Regex.IsMatch(ph, regPhone))
            {
                //MessageBox.Show("Phone number is valid! :)");
            }
            else
            {
                MessageBox.Show("Incorrect phone number, try again.");
            }

            //regEx eirCode checker
            if (Regex.IsMatch(eirC, regEirCode)) 
            {

            }
            else
            {
                MessageBox.Show("Incorrect eir code, try again.");
            }

            //regEx email checker
            if (Regex.IsMatch(ema, regEmail))
            {

            }
            else
            {
                MessageBox.Show("Incorrect email, try again.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpAge_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dtpAge.Value.Year;
            lblAgeShow.Text = currentAge.ToString();
            lblAgeShow.Show();
        }
    }
}
