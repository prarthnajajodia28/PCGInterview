using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.business;

namespace WindowsFormsApplication2
{

    public partial class Display : Form
    {
        private static MySystem mySystem;

        public Display()
        {

            InitializeComponent();
            mySystem = ConfigureASytem.configure();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void viewDirectory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDirectory vD = new ViewDirectory();
            vD.Show();
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
