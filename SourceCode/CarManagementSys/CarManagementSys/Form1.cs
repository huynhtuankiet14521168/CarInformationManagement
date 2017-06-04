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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTileButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin Login = new LoginAdmin();
            Login.ShowDialog();
            this.Close();
        }

        private void bunifuTileButtonGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest G = new Guest();
            G.ShowDialog();
            this.Close();
        }
    }
}
