﻿using System;
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
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            AddLecturer l = new AddLecturer();
            l.ShowDialog();
            //this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            AddStudent s = new AddStudent();
            s.ShowDialog();
            //this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowData sd = new ShowData();
            sd.ShowDialog();
            //this.Hide();
        }
    }
}
