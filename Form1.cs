using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo);

            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a MessageBox. Do you want another?", "while", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int value = this.trkBarLoop.Value;
            for (int i = 0; i < value; i++)
            {
                MessageBox.Show("Here's MessageBox " + i);
            }

        }

       
    }
}
       
