using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorVehicle
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
           

        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.TextLength == 3)
            {
                textBox2.Focus();
            }
            if(textBox1.Text!=)
            {
                MessageBox.Show("Error");
            }
            textBox1.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (textBox2.TextLength == 3)
                {
                    textBox3.Focus();
                }
                         
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox3.TextLength == 3)
            {
                Search_btn.Focus();
            }
        }
    }
}
