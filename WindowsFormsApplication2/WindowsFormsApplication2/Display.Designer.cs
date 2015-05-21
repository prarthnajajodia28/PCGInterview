namespace WindowsFormsApplication2
{
    partial class Display
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
            this.addStudent = new System.Windows.Forms.Button();
            this.viewDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(235, 54);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(237, 38);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewDirectory
            // 
            this.viewDirectory.Location = new System.Drawing.Point(235, 131);
            this.viewDirectory.Name = "viewDirectory";
            this.viewDirectory.Size = new System.Drawing.Size(237, 39);
            this.viewDirectory.TabIndex = 1;
            this.viewDirectory.Text = "View Directory";
            this.viewDirectory.UseVisualStyleBackColor = true;
            this.viewDirectory.Click += new System.EventHandler(this.viewDirectory_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 316);
            this.Controls.Add(this.viewDirectory);
            this.Controls.Add(this.addStudent);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button viewDirectory;
    }
}