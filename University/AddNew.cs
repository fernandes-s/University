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
            Lecturer l = new Lecturer();
            l.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.ShowDialog();
        }

    }
}
