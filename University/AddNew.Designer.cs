namespace University
{
    partial class AddNew
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.FlatAppearance.BorderSize = 3;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Arial", 16F);
            this.btnStudent.Location = new System.Drawing.Point(40, 183);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(250, 54);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Add Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.BackColor = System.Drawing.SystemColors.Control;
            this.btnLecturer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLecturer.FlatAppearance.BorderSize = 3;
            this.btnLecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturer.Font = new System.Drawing.Font("Arial", 16F);
            this.btnLecturer.Location = new System.Drawing.Point(40, 123);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(250, 54);
            this.btnLecturer.TabIndex = 5;
            this.btnLecturer.Text = "Add Lecturer";
            this.btnLecturer.UseVisualStyleBackColor = false;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShow.FlatAppearance.BorderSize = 3;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial", 16F);
            this.btnShow.Location = new System.Drawing.Point(40, 243);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(250, 54);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Data";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 53);
            this.label3.TabIndex = 21;
            this.label3.Text = "What would you ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 53);
            this.label1.TabIndex = 22;
            this.label1.Text = "like to do:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(342, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnLecturer);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}