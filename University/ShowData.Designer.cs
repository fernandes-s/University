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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowStu = new System.Windows.Forms.Button();
            this.btnShowLecturers = new System.Windows.Forms.Button();
            this.cboShowGender = new System.Windows.Forms.ComboBox();
            this.cboShowCy = new System.Windows.Forms.ComboBox();
            this.lblGe = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.LblCy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoUnder50 = new System.Windows.Forms.RadioButton();
            this.rdoUnder100 = new System.Windows.Forms.RadioButton();
            this.rdoOver100 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowStu
            // 
            this.btnShowStu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowStu.FlatAppearance.BorderSize = 3;
            this.btnShowStu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStu.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowStu.Location = new System.Drawing.Point(12, 61);
            this.btnShowStu.Name = "btnShowStu";
            this.btnShowStu.Size = new System.Drawing.Size(171, 46);
            this.btnShowStu.TabIndex = 35;
            this.btnShowStu.Text = "Students";
            this.btnShowStu.UseVisualStyleBackColor = true;
            // 
            // btnShowLecturers
            // 
            this.btnShowLecturers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowLecturers.FlatAppearance.BorderSize = 3;
            this.btnShowLecturers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLecturers.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShowLecturers.Location = new System.Drawing.Point(210, 61);
            this.btnShowLecturers.Name = "btnShowLecturers";
            this.btnShowLecturers.Size = new System.Drawing.Size(171, 46);
            this.btnShowLecturers.TabIndex = 36;
            this.btnShowLecturers.Text = "Lecturers";
            this.btnShowLecturers.UseVisualStyleBackColor = true;
            // 
            // cboShowGender
            // 
            this.cboShowGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowGender.FormattingEnabled = true;
            this.cboShowGender.Location = new System.Drawing.Point(409, 32);
            this.cboShowGender.Name = "cboShowGender";
            this.cboShowGender.Size = new System.Drawing.Size(181, 39);
            this.cboShowGender.TabIndex = 37;
            // 
            // cboShowCy
            // 
            this.cboShowCy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShowCy.FormattingEnabled = true;
            this.cboShowCy.Location = new System.Drawing.Point(650, 32);
            this.cboShowCy.Name = "cboShowCy";
            this.cboShowCy.Size = new System.Drawing.Size(181, 39);
            this.cboShowCy.TabIndex = 40;
            // 
            // lblGe
            // 
            this.lblGe.AutoSize = true;
            this.lblGe.Location = new System.Drawing.Point(406, 13);
            this.lblGe.Name = "lblGe";
            this.lblGe.Size = new System.Drawing.Size(52, 16);
            this.lblGe.TabIndex = 41;
            this.lblGe.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(647, 83);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 42;
            this.lblAge.Text = "Age";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(406, 83);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(46, 16);
            this.lblSal.TabIndex = 43;
            this.lblSal.Text = "Salary";
            // 
            // LblCy
            // 
            this.LblCy.AutoSize = true;
            this.LblCy.Location = new System.Drawing.Point(647, 13);
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
            // rdoUnder50
            // 
            this.rdoUnder50.AutoSize = true;
            this.rdoUnder50.Location = new System.Drawing.Point(409, 102);
            this.rdoUnder50.Name = "rdoUnder50";
            this.rdoUnder50.Size = new System.Drawing.Size(97, 20);
            this.rdoUnder50.TabIndex = 46;
            this.rdoUnder50.TabStop = true;
            this.rdoUnder50.Text = "Under $50K";
            this.rdoUnder50.UseVisualStyleBackColor = true;
            // 
            // rdoUnder100
            // 
            this.rdoUnder100.AutoSize = true;
            this.rdoUnder100.Location = new System.Drawing.Point(409, 128);
            this.rdoUnder100.Name = "rdoUnder100";
            this.rdoUnder100.Size = new System.Drawing.Size(104, 20);
            this.rdoUnder100.TabIndex = 47;
            this.rdoUnder100.TabStop = true;
            this.rdoUnder100.Text = "Under $100K";
            this.rdoUnder100.UseVisualStyleBackColor = true;
            // 
            // rdoOver100
            // 
            this.rdoOver100.AutoSize = true;
            this.rdoOver100.Location = new System.Drawing.Point(409, 154);
            this.rdoOver100.Name = "rdoOver100";
            this.rdoOver100.Size = new System.Drawing.Size(96, 20);
            this.rdoOver100.TabIndex = 48;
            this.rdoOver100.TabStop = true;
            this.rdoOver100.Text = "Over $100K";
            this.rdoOver100.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(650, 154);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 20);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "54 - 65";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(650, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 50;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "41 - 53";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(650, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 20);
            this.radioButton3.TabIndex = 49;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "18 - 40";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 577);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rdoOver100);
            this.Controls.Add(this.rdoUnder100);
            this.Controls.Add(this.rdoUnder50);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LblCy);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGe);
            this.Controls.Add(this.cboShowCy);
            this.Controls.Add(this.cboShowGender);
            this.Controls.Add(this.btnShowLecturers);
            this.Controls.Add(this.btnShowStu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowStu;
        private System.Windows.Forms.Button btnShowLecturers;
        private System.Windows.Forms.ComboBox cboShowGender;
        private System.Windows.Forms.ComboBox cboShowCy;
        private System.Windows.Forms.Label lblGe;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label LblCy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoUnder50;
        private System.Windows.Forms.RadioButton rdoUnder100;
        private System.Windows.Forms.RadioButton rdoOver100;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}