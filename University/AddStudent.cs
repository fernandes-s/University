using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboCourse.DataSource = Enum.GetValues(typeof(Department));           


        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string eirC = txtEirCode.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string age = lblAgeShow.Text; // use age label or dtp need to check
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
            string cour = cboCourse.SelectedItem.ToString();
            string mod = cboModule.SelectedItem.ToString();

            Student s = new Student(fn, sn, eirC, cy, age, ge, ph, ema, cour, mod);

            s.AddNewStudent(fn, sn, eirC, cy, age, ge, ph, ema, cour, mod);
            MessageBox.Show("New Student Added to Database", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtFn.Clear();
            txtSn.Clear();
            txtEirCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCourse.SelectedIndex.Equals(0))
                cboModule.DataSource = Enum.GetValues(typeof(ModuleCS));
            if (cboCourse.SelectedIndex.Equals(1))
                cboModule.DataSource = Enum.GetValues(typeof(ModuleMa));
            if (cboCourse.SelectedIndex.Equals(2))
                cboModule.DataSource = Enum.GetValues(typeof(ModuleGe));
            if (cboCourse.SelectedIndex.Equals(3))
                cboModule.DataSource = Enum.GetValues(typeof(ModuleMe));


        }

        private void dtpAge_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dtpAge.Value.Year;
            lblAgeShow.Text = currentAge.ToString();
            lblAgeShow.Show();
        }

        //Validating
        //EirCode
        private void txtEirCode_Validating(object sender, CancelEventArgs e)
        {
            string regEirCode = @"^[A-Za-z]\d{1,2}[A-Za-z0-9]{4}$";
            bool isValidEirCode = Regex.IsMatch(txtEirCode.Text, regEirCode);

            if (!isValidEirCode)
            {
                epError.SetError(txtEirCode, "Incorrect eir code, try again. You must follow the pattern E.G: D01F123");
                e.Cancel = true;
            }
        }

        //Phone
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string regPhone = @"^\d{3}-\d{7}$";
            bool isValidPhone = Regex.IsMatch(txtPhone.Text, regPhone);

            if (!isValidPhone)
            {
                epError.SetError(txtPhone, "Incorrect phone number, try again. You must follow the pattern E.G: 012-1234567");
                e.Cancel = true;
            }
        }

        //Email
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string regEmail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            bool isValidEmail = Regex.IsMatch(txtEmail.Text, regEmail);

            if (!isValidEmail)
            {
                epError.SetError(txtEmail, "Incorrect email, try again. You must follow the pattern E.G: abc@abc.abc");
                e.Cancel = true;
            }
        }


        //Validated
        //EirCode
        private void txtEirCode_Validated(object sender, EventArgs e)
        {
            epError.Clear();
        }

        //Phone
        private void txtPhone_Validated(object sender, EventArgs e)
        {
            epError.Clear();
        }

        //Email
        private void txtEmail_Validated(object sender, EventArgs e)
        {
            epError.Clear();
        }
    }
}
