using Financal_Management_System.controller;
using Financal_Management_System.enumacation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financal_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Controller controller =new Controller();
            LoginState result=controller.login(txt_kullaniciID.Text,txt_password.Text);

            if (result==LoginState.successful)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else if (result==LoginState.failed)
            {
                MessageBox.Show("Incorrect Entry","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Missing Information","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
