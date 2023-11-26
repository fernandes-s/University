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
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.FlatAppearance.BorderSize = 3;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Arial", 16F);
            this.btnStudent.Location = new System.Drawing.Point(34, 183);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(280, 54);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLecturer.FlatAppearance.BorderSize = 3;
            this.btnLecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturer.Font = new System.Drawing.Font("Arial", 16F);
            this.btnLecturer.Location = new System.Drawing.Point(34, 123);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(280, 54);
            this.btnLecturer.TabIndex = 5;
            this.btnLecturer.Text = "Lecturer";
            this.btnLecturer.UseVisualStyleBackColor = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 259);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnLecturer);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLecturer;
    }
}