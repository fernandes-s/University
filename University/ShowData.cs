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
    public partial class ShowData : Form
    {
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
    }
}
