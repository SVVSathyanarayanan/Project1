using System;
using System.Windows.Forms;

namespace MotorVehicle
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motor_frm a = new Motor_frm();
            a.Show();
            this.Hide();
        }
        private void Login_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
