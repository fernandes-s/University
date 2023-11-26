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

namespace University
{
    public partial class Lecturer : Form
    {
        //Person p = new Person();
        public Lecturer()
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
            string dob = dtpAge.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string ge = "Male";
            if (rdoFemale.Checked)
            {
                ge = "Female";
            }
            string dept = cboDpt.SelectedItem.ToString();
            //float pay = float.Parse(txtSal.Text);

            //p.Add(fn, sn, dob, cy, ge, dept, pay);
            //MessageBox.Show("Data Added", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////message box has four parameters
            ////1 message
            ////2 title
            ////3 button
            //4 icon
            txtFn.Clear();
            txtSn.Clear();
            txtSal.Clear();




            string eirCode = txtEirCode.Text;
            string regEirCode = @"^[A-Za-z]\d{1,2}[A-Za-z0-9]{4}$";

            string phone = txtPhone.Text;
            string regPhone = @"^\d{3}-\d{7}$";

            string email = txtEmail.Text;
            string regEmail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(phone, regPhone))
            {
                //MessageBox.Show("Phone number is valid! :)");
            }
            else
            {
                MessageBox.Show("Incorrect phone number, try again.");
            }

            if (Regex.IsMatch(eirCode, regEirCode)) 
            {

            }
            else
            {
                MessageBox.Show("Incorrect eir code, try again.");
            }

            if (Regex.IsMatch(email, regEmail))
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

        private void lblAgeShow_Click(object sender, EventArgs e)
        {
            //age just shows if the button is clecked. other way to do it
            
        }

        private void dtpAge_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dtpAge.Value.Year;
            lblAgeShow.Text = currentAge.ToString();
            lblAgeShow.Show();
        }
    }
}
