namespace WindowsFormsApplication2
{
    partial class ViewDirectory
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
            this.Back = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.assignment3 = new System.Windows.Forms.Label();
            this.assignment2 = new System.Windows.Forms.Label();
            this.assignment1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(37, 206);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 28);
            this.Back.TabIndex = 30;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student Name";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grade";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(37, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 178);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // assignment3
            // 
            this.assignment3.AutoSize = true;
            this.assignment3.Location = new System.Drawing.Point(484, 141);
            this.assignment3.Name = "assignment3";
            this.assignment3.Size = new System.Drawing.Size(0, 13);
            this.assignment3.TabIndex = 41;
            // 
            // assignment2
            // 
            this.assignment2.AutoSize = true;
            this.assignment2.Location = new System.Drawing.Point(484, 103);
            this.assignment2.Name = "assignment2";
            this.assignment2.Size = new System.Drawing.Size(0, 13);
            this.assignment2.TabIndex = 40;
            // 
            // assignment1
            // 
            this.assignment1.AutoSize = true;
            this.assignment1.Location = new System.Drawing.Point(484, 64);
            this.assignment1.Name = "assignment1";
            this.assignment1.Size = new System.Drawing.Size(0, 13);
            this.assignment1.TabIndex = 39;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(446, 27);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 20);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "Marks";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(373, 141);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 13);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Assignment 3";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(373, 103);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 13);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "Assignment 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(373, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Assignment 1 ";
            // 
            // ViewDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 362);
            this.Controls.Add(this.assignment3);
            this.Controls.Add(this.assignment2);
            this.Controls.Add(this.assignment1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Back);
            this.Name = "ViewDirectory";
            this.Text = "ViewDirectory";
            this.Load += new System.EventHandler(this.ViewDirectory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Back;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.Label assignment3;
        internal System.Windows.Forms.Label assignment2;
        internal System.Windows.Forms.Label assignment1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}