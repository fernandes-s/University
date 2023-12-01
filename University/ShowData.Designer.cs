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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnShowStu = new System.Windows.Forms.Button();
            this.btnShowLecturers = new System.Windows.Forms.Button();
            this.cboShowGender = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 182);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(982, 383);
            this.dgv.TabIndex = 0;
            // 
            // btnShowStu
            // 
            this.btnShowStu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowStu.FlatAppearance.BorderSize = 3;
            this.btnShowStu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStu.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowStu.Location = new System.Drawing.Point(12, 25);
            this.btnShowStu.Name = "btnShowStu";
            this.btnShowStu.Size = new System.Drawing.Size(171, 46);
            this.btnShowStu.TabIndex = 35;
            this.btnShowStu.Text = "Students";
            this.btnShowStu.UseVisualStyleBackColor = true;
            this.btnShowStu.Click += new System.EventHandler(this.btnShowStu_Click);
            // 
            // btnShowLecturers
            // 
            this.btnShowLecturers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowLecturers.FlatAppearance.BorderSize = 3;
            this.btnShowLecturers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLecturers.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowLecturers.Location = new System.Drawing.Point(12, 102);
            this.btnShowLecturers.Name = "btnShowLecturers";
            this.btnShowLecturers.Size = new System.Drawing.Size(171, 46);
            this.btnShowLecturers.TabIndex = 36;
            this.btnShowLecturers.Text = "Lecturers";
            this.btnShowLecturers.UseVisualStyleBackColor = true;
            this.btnShowLecturers.Click += new System.EventHandler(this.btnShowLecturers_Click);
            // 
            // cboShowGender
            // 
            this.cboShowGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowGender.FormattingEnabled = true;
            this.cboShowGender.Location = new System.Drawing.Point(215, 64);
            this.cboShowGender.Name = "cboShowGender";
            this.cboShowGender.Size = new System.Drawing.Size(181, 39);
            this.cboShowGender.TabIndex = 37;
            this.cboShowGender.SelectedIndexChanged += new System.EventHandler(this.cboShowGender_SelectedIndexChanged);
            // 
            // cboShowCy
            // 
            this.cboShowCy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowCy.FormattingEnabled = true;
            this.cboShowCy.Location = new System.Drawing.Point(436, 64);
            this.cboShowCy.Name = "cboShowCy";
            this.cboShowCy.Size = new System.Drawing.Size(181, 39);
            this.cboShowCy.TabIndex = 40;
            // 
            // lblGe
            // 
            this.lblGe.AutoSize = true;
            this.lblGe.Location = new System.Drawing.Point(212, 45);
            this.lblGe.Name = "lblGe";
            this.lblGe.Size = new System.Drawing.Size(52, 16);
            this.lblGe.TabIndex = 41;
            this.lblGe.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(843, 45);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 42;
            this.lblAge.Text = "Age";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(676, 45);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(46, 16);
            this.lblSal.TabIndex = 43;
            this.lblSal.Text = "Salary";
            // 
            // LblCy
            // 
            this.LblCy.AutoSize = true;
            this.LblCy.Location = new System.Drawing.Point(433, 45);
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
            this.btnClose.Location = new System.Drawing.Point(870, 507);
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
            this.rdoUnder50k.Location = new System.Drawing.Point(679, 64);
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
            this.rdoOver100k.Location = new System.Drawing.Point(679, 116);
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
            this.rdo50over.Location = new System.Drawing.Point(846, 116);
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
            this.rdo31to49.Location = new System.Drawing.Point(846, 90);
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
            this.rdb18to30.Location = new System.Drawing.Point(846, 64);
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
            this.rdo50to100k.Location = new System.Drawing.Point(678, 90);
            this.rdo50to100k.Name = "rdo50to100k";
            this.rdo50to100k.Size = new System.Drawing.Size(95, 20);
            this.rdo50to100k.TabIndex = 53;
            this.rdo50to100k.TabStop = true;
            this.rdo50to100k.Text = "$50K - 100k";
            this.rdo50to100k.UseVisualStyleBackColor = true;
            this.rdo50to100k.CheckedChanged += new System.EventHandler(this.rdo50to100k_CheckedChanged);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
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
            this.Controls.Add(this.cboShowGender);
            this.Controls.Add(this.btnShowLecturers);
            this.Controls.Add(this.btnShowStu);
            this.Controls.Add(this.dgv);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnShowStu;
        private System.Windows.Forms.Button btnShowLecturers;
        private System.Windows.Forms.ComboBox cboShowGender;
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
    }
}