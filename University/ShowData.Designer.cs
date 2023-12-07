namespace University
{
    partial class ShowData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.btnShowStu = new System.Windows.Forms.Button();
            this.btnShowLecturers = new System.Windows.Forms.Button();
            this.cboShowGenderLec = new System.Windows.Forms.ComboBox();
            this.cboShowCy = new System.Windows.Forms.ComboBox();
            this.lblGe = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.LblCy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoUnder50k = new System.Windows.Forms.RadioButton();
            this.rdoOver100k = new System.Windows.Forms.RadioButton();
            this.rdo50over = new System.Windows.Forms.RadioButton();
            this.rdo31to49 = new System.Windows.Forms.RadioButton();
            this.rdb18to30 = new System.Windows.Forms.RadioButton();
            this.rdo50to100k = new System.Windows.Forms.RadioButton();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblGeStu = new System.Windows.Forms.Label();
            this.cboShowGenderStu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboShowCyStu = new System.Windows.Forms.ComboBox();
            this.lblSortAgeStu = new System.Windows.Forms.Label();
            this.cboSortAgeStu = new System.Windows.Forms.ComboBox();
            this.lblSortSalLec = new System.Windows.Forms.Label();
            this.cboSortNameLec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturer.Location = new System.Drawing.Point(12, 97);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.RowHeadersWidth = 51;
            this.dgvLecturer.RowTemplate.Height = 24;
            this.dgvLecturer.Size = new System.Drawing.Size(1429, 195);
            this.dgvLecturer.TabIndex = 0;
            // 
            // btnShowStu
            // 
            this.btnShowStu.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowStu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowStu.FlatAppearance.BorderSize = 3;
            this.btnShowStu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStu.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowStu.Location = new System.Drawing.Point(12, 332);
            this.btnShowStu.Name = "btnShowStu";
            this.btnShowStu.Size = new System.Drawing.Size(171, 46);
            this.btnShowStu.TabIndex = 35;
            this.btnShowStu.Text = "Students";
            this.btnShowStu.UseVisualStyleBackColor = false;
            this.btnShowStu.Click += new System.EventHandler(this.btnShowStu_Click);
            // 
            // btnShowLecturers
            // 
            this.btnShowLecturers.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowLecturers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowLecturers.FlatAppearance.BorderSize = 3;
            this.btnShowLecturers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLecturers.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowLecturers.Location = new System.Drawing.Point(12, 12);
            this.btnShowLecturers.Name = "btnShowLecturers";
            this.btnShowLecturers.Size = new System.Drawing.Size(171, 46);
            this.btnShowLecturers.TabIndex = 36;
            this.btnShowLecturers.Text = "Lecturers";
            this.btnShowLecturers.UseVisualStyleBackColor = false;
            this.btnShowLecturers.Click += new System.EventHandler(this.btnShowLecturers_Click);
            // 
            // cboShowGenderLec
            // 
            this.cboShowGenderLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowGenderLec.FormattingEnabled = true;
            this.cboShowGenderLec.Location = new System.Drawing.Point(212, 19);
            this.cboShowGenderLec.Name = "cboShowGenderLec";
            this.cboShowGenderLec.Size = new System.Drawing.Size(181, 39);
            this.cboShowGenderLec.TabIndex = 37;
            this.cboShowGenderLec.SelectedIndexChanged += new System.EventHandler(this.cboShowGender_SelectedIndexChanged);
            // 
            // cboShowCy
            // 
            this.cboShowCy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowCy.FormattingEnabled = true;
            this.cboShowCy.Location = new System.Drawing.Point(433, 19);
            this.cboShowCy.Name = "cboShowCy";
            this.cboShowCy.Size = new System.Drawing.Size(181, 39);
            this.cboShowCy.TabIndex = 40;
            this.cboShowCy.SelectedIndexChanged += new System.EventHandler(this.cboShowCy_SelectedIndexChanged);
            // 
            // lblGe
            // 
            this.lblGe.AutoSize = true;
            this.lblGe.Location = new System.Drawing.Point(209, 0);
            this.lblGe.Name = "lblGe";
            this.lblGe.Size = new System.Drawing.Size(52, 16);
            this.lblGe.TabIndex = 41;
            this.lblGe.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(792, 324);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 42;
            this.lblAge.Text = "Age";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(784, 9);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(46, 16);
            this.lblSal.TabIndex = 43;
            this.lblSal.Text = "Salary";
            // 
            // LblCy
            // 
            this.LblCy.AutoSize = true;
            this.LblCy.Location = new System.Drawing.Point(430, 0);
            this.LblCy.Name = "LblCy";
            this.LblCy.Size = new System.Drawing.Size(48, 16);
            this.LblCy.TabIndex = 44;
            this.LblCy.Text = "County";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 16F);
            this.btnClose.Location = new System.Drawing.Point(1327, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 47);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoUnder50k
            // 
            this.rdoUnder50k.AutoSize = true;
            this.rdoUnder50k.Location = new System.Drawing.Point(653, 38);
            this.rdoUnder50k.Name = "rdoUnder50k";
            this.rdoUnder50k.Size = new System.Drawing.Size(97, 20);
            this.rdoUnder50k.TabIndex = 46;
            this.rdoUnder50k.TabStop = true;
            this.rdoUnder50k.Text = "Under $50K";
            this.rdoUnder50k.UseVisualStyleBackColor = true;
            this.rdoUnder50k.CheckedChanged += new System.EventHandler(this.rdoUnder50k_CheckedChanged);
            // 
            // rdoOver100k
            // 
            this.rdoOver100k.AutoSize = true;
            this.rdoOver100k.Location = new System.Drawing.Point(876, 38);
            this.rdoOver100k.Name = "rdoOver100k";
            this.rdoOver100k.Size = new System.Drawing.Size(96, 20);
            this.rdoOver100k.TabIndex = 48;
            this.rdoOver100k.TabStop = true;
            this.rdoOver100k.Text = "Over $100K";
            this.rdoOver100k.UseVisualStyleBackColor = true;
            this.rdoOver100k.CheckedChanged += new System.EventHandler(this.rdoOver100k_CheckedChanged);
            // 
            // rdo50over
            // 
            this.rdo50over.AutoSize = true;
            this.rdo50over.Location = new System.Drawing.Point(848, 350);
            this.rdo50over.Name = "rdo50over";
            this.rdo50over.Size = new System.Drawing.Size(74, 20);
            this.rdo50over.TabIndex = 51;
            this.rdo50over.TabStop = true;
            this.rdo50over.Text = "Over 50";
            this.rdo50over.UseVisualStyleBackColor = true;
            this.rdo50over.CheckedChanged += new System.EventHandler(this.rdo50over_CheckedChanged);
            // 
            // rdo31to49
            // 
            this.rdo31to49.AutoSize = true;
            this.rdo31to49.Location = new System.Drawing.Point(764, 350);
            this.rdo31to49.Name = "rdo31to49";
            this.rdo31to49.Size = new System.Drawing.Size(66, 20);
            this.rdo31to49.TabIndex = 50;
            this.rdo31to49.TabStop = true;
            this.rdo31to49.Text = "31 - 49";
            this.rdo31to49.UseVisualStyleBackColor = true;
            this.rdo31to49.CheckedChanged += new System.EventHandler(this.rdo31to49_CheckedChanged);
            // 
            // rdb18to30
            // 
            this.rdb18to30.AutoSize = true;
            this.rdb18to30.Location = new System.Drawing.Point(678, 350);
            this.rdb18to30.Name = "rdb18to30";
            this.rdb18to30.Size = new System.Drawing.Size(66, 20);
            this.rdb18to30.TabIndex = 52;
            this.rdb18to30.TabStop = true;
            this.rdb18to30.Text = "18 - 30";
            this.rdb18to30.UseVisualStyleBackColor = true;
            this.rdb18to30.CheckedChanged += new System.EventHandler(this.rdb18to40_CheckedChanged);
            // 
            // rdo50to100k
            // 
            this.rdo50to100k.AutoSize = true;
            this.rdo50to100k.Location = new System.Drawing.Point(764, 38);
            this.rdo50to100k.Name = "rdo50to100k";
            this.rdo50to100k.Size = new System.Drawing.Size(95, 20);
            this.rdo50to100k.TabIndex = 53;
            this.rdo50to100k.TabStop = true;
            this.rdo50to100k.Text = "$50K - 100k";
            this.rdo50to100k.UseVisualStyleBackColor = true;
            this.rdo50to100k.CheckedChanged += new System.EventHandler(this.rdo50to100k_CheckedChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(12, 402);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(1429, 195);
            this.dgvStudent.TabIndex = 54;
            // 
            // lblGeStu
            // 
            this.lblGeStu.AutoSize = true;
            this.lblGeStu.Location = new System.Drawing.Point(209, 320);
            this.lblGeStu.Name = "lblGeStu";
            this.lblGeStu.Size = new System.Drawing.Size(52, 16);
            this.lblGeStu.TabIndex = 56;
            this.lblGeStu.Text = "Gender";
            // 
            // cboShowGenderStu
            // 
            this.cboShowGenderStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowGenderStu.FormattingEnabled = true;
            this.cboShowGenderStu.Location = new System.Drawing.Point(212, 339);
            this.cboShowGenderStu.Name = "cboShowGenderStu";
            this.cboShowGenderStu.Size = new System.Drawing.Size(181, 39);
            this.cboShowGenderStu.TabIndex = 55;
            this.cboShowGenderStu.SelectedIndexChanged += new System.EventHandler(this.cboShowGenderStu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "County";
            // 
            // cboShowCyStu
            // 
            this.cboShowCyStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowCyStu.FormattingEnabled = true;
            this.cboShowCyStu.Location = new System.Drawing.Point(433, 339);
            this.cboShowCyStu.Name = "cboShowCyStu";
            this.cboShowCyStu.Size = new System.Drawing.Size(181, 39);
            this.cboShowCyStu.TabIndex = 57;
            this.cboShowCyStu.SelectedIndexChanged += new System.EventHandler(this.cboShowCyStu_SelectedIndexChanged);
            // 
            // lblSortAgeStu
            // 
            this.lblSortAgeStu.AutoSize = true;
            this.lblSortAgeStu.Location = new System.Drawing.Point(1002, 320);
            this.lblSortAgeStu.Name = "lblSortAgeStu";
            this.lblSortAgeStu.Size = new System.Drawing.Size(59, 16);
            this.lblSortAgeStu.TabIndex = 60;
            this.lblSortAgeStu.Text = "Sort Age";
            // 
            // cboSortAgeStu
            // 
            this.cboSortAgeStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAgeStu.FormattingEnabled = true;
            this.cboSortAgeStu.Location = new System.Drawing.Point(1005, 339);
            this.cboSortAgeStu.Name = "cboSortAgeStu";
            this.cboSortAgeStu.Size = new System.Drawing.Size(181, 39);
            this.cboSortAgeStu.TabIndex = 59;
            this.cboSortAgeStu.SelectedIndexChanged += new System.EventHandler(this.cboSortAgeStu_SelectedIndexChanged);
            // 
            // lblSortSalLec
            // 
            this.lblSortSalLec.AutoSize = true;
            this.lblSortSalLec.Location = new System.Drawing.Point(1002, 0);
            this.lblSortSalLec.Name = "lblSortSalLec";
            this.lblSortSalLec.Size = new System.Drawing.Size(71, 16);
            this.lblSortSalLec.TabIndex = 62;
            this.lblSortSalLec.Text = "Sort Name";
            // 
            // cboSortNameLec
            // 
            this.cboSortNameLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortNameLec.FormattingEnabled = true;
            this.cboSortNameLec.Location = new System.Drawing.Point(1005, 24);
            this.cboSortNameLec.Name = "cboSortNameLec";
            this.cboSortNameLec.Size = new System.Drawing.Size(181, 39);
            this.cboSortNameLec.TabIndex = 61;
            this.cboSortNameLec.SelectedIndexChanged += new System.EventHandler(this.cboSortSalLec_SelectedIndexChanged);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1536, 646);
            this.Controls.Add(this.lblSortSalLec);
            this.Controls.Add(this.cboSortNameLec);
            this.Controls.Add(this.lblSortAgeStu);
            this.Controls.Add(this.cboSortAgeStu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboShowCyStu);
            this.Controls.Add(this.lblGeStu);
            this.Controls.Add(this.cboShowGenderStu);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.rdo50to100k);
            this.Controls.Add(this.rdb18to30);
            this.Controls.Add(this.rdo50over);
            this.Controls.Add(this.rdo31to49);
            this.Controls.Add(this.rdoOver100k);
            this.Controls.Add(this.rdoUnder50k);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LblCy);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGe);
            this.Controls.Add(this.cboShowCy);
            this.Controls.Add(this.cboShowGenderLec);
            this.Controls.Add(this.btnShowLecturers);
            this.Controls.Add(this.btnShowStu);
            this.Controls.Add(this.dgvLecturer);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLecturer;
        private System.Windows.Forms.Button btnShowStu;
        private System.Windows.Forms.Button btnShowLecturers;
        private System.Windows.Forms.ComboBox cboShowGenderLec;
        private System.Windows.Forms.ComboBox cboShowCy;
        private System.Windows.Forms.Label lblGe;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label LblCy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoUnder50k;
        private System.Windows.Forms.RadioButton rdoOver100k;
        private System.Windows.Forms.RadioButton rdo50over;
        private System.Windows.Forms.RadioButton rdo31to49;
        private System.Windows.Forms.RadioButton rdb18to30;
        private System.Windows.Forms.RadioButton rdo50to100k;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblGeStu;
        private System.Windows.Forms.ComboBox cboShowGenderStu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboShowCyStu;
        private System.Windows.Forms.Label lblSortAgeStu;
        private System.Windows.Forms.ComboBox cboSortAgeStu;
        private System.Windows.Forms.Label lblSortSalLec;
        private System.Windows.Forms.ComboBox cboSortNameLec;
    }
}