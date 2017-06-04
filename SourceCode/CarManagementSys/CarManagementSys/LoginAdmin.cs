using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSys
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator Admin = new Administrator();
            Admin.ShowDialog();
            this.Close();
        }

        private void ThinButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Exit = new Form1();
            Exit.ShowDialog();
            this.Close();
        }
    }
}
