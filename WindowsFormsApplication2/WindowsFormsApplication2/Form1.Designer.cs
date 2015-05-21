namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.Success = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.assignment3 = new System.Windows.Forms.TextBox();
            this.assignment2 = new System.Windows.Forms.TextBox();
            this.assignment1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.name_error = new System.Windows.Forms.Label();
            this.error_ass1 = new System.Windows.Forms.Label();
            this.error_ass2 = new System.Windows.Forms.Label();
            this.error_ass3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Location = new System.Drawing.Point(310, 270);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(0, 13);
            this.Success.TabIndex = 25;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(354, 104);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 20);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Marks";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(170, 222);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 13);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Assignment 3";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(170, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 13);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Assignment 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(170, 145);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Assignment 1 ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(168, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Student Name";
            // 
            // assignment3
            // 
            this.assignment3.Location = new System.Drawing.Point(422, 215);
            this.assignment3.Name = "assignment3";
            this.assignment3.Size = new System.Drawing.Size(70, 20);
            this.assignment3.TabIndex = 18;
            this.assignment3.TextChanged += new System.EventHandler(this.assignment3_TextChanged);
            // 
            // assignment2
            // 
            this.assignment2.Location = new System.Drawing.Point(422, 177);
            this.assignment2.Name = "assignment2";
            this.assignment2.Size = new System.Drawing.Size(70, 20);
            this.assignment2.TabIndex = 17;
            // 
            // assignment1
            // 
            this.assignment1.Location = new System.Drawing.Point(422, 138);
            this.assignment1.Name = "assignment1";
            this.assignment1.Size = new System.Drawing.Size(70, 20);
            this.assignment1.TabIndex = 16;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(422, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(194, 20);
            this.name.TabIndex = 15;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(448, 332);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 28);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add Student";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(287, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(205, 24);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Enter Student Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "/100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "/100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "/100";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(159, 332);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 28);
            this.Back.TabIndex = 29;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_error
            // 
            this.name_error.AutoSize = true;
            this.name_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_error.ForeColor = System.Drawing.Color.Red;
            this.name_error.Location = new System.Drawing.Point(658, 66);
            this.name_error.Name = "name_error";
            this.name_error.Size = new System.Drawing.Size(0, 13);
            this.name_error.TabIndex = 30;
            // 
            // error_ass1
            // 
            this.error_ass1.AutoSize = true;
            this.error_ass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_ass1.ForeColor = System.Drawing.Color.Red;
            this.error_ass1.Location = new System.Drawing.Point(563, 141);
            this.error_ass1.Name = "error_ass1";
            this.error_ass1.Size = new System.Drawing.Size(0, 13);
            this.error_ass1.TabIndex = 31;
            // 
            // error_ass2
            // 
            this.error_ass2.AutoSize = true;
            this.error_ass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_ass2.ForeColor = System.Drawing.Color.Red;
            this.error_ass2.Location = new System.Drawing.Point(563, 180);
            this.error_ass2.Name = "error_ass2";
            this.error_ass2.Size = new System.Drawing.Size(0, 13);
            this.error_ass2.TabIndex = 32;
            // 
            // error_ass3
            // 
            this.error_ass3.AutoSize = true;
            this.error_ass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_ass3.ForeColor = System.Drawing.Color.Red;
            this.error_ass3.Location = new System.Drawing.Point(563, 215);
            this.error_ass3.Name = "error_ass3";
            this.error_ass3.Size = new System.Drawing.Size(0, 13);
            this.error_ass3.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 376);
            this.Controls.Add(this.error_ass3);
            this.Controls.Add(this.error_ass2);
            this.Controls.Add(this.error_ass1);
            this.Controls.Add(this.name_error);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.assignment3);
            this.Controls.Add(this.assignment2);
            this.Controls.Add(this.assignment1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Success;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox assignment3;
        internal System.Windows.Forms.TextBox assignment2;
        internal System.Windows.Forms.TextBox assignment1;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Button Add;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button Back;
        internal System.Windows.Forms.Label name_error;
        internal System.Windows.Forms.Label error_ass1;
        internal System.Windows.Forms.Label error_ass2;
        internal System.Windows.Forms.Label error_ass3;
    }
}

