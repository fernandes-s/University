using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class AddStudent : Form
    {
        AddPeople ap = new AddPeople();
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
            //Person p = new Person();
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string eirC = txtEirCode.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string age = lblAgeShow.Text; // use age label or dtp need to check
            string ge = "Male";
            if (rdoFemale.Checked)
                ge = "Female";
            string ph = txtPhone.Text;
            string ema = txtEmail.Text;
            string course = cboCourse.SelectedItem.ToString();
            string modu = cboModule.SelectedItem.ToString();





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboModule_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
