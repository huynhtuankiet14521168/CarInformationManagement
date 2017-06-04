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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin Logout = new LoginAdmin();
            Logout.ShowDialog();
            this.Close();
        }

        private void TileButtonEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagement EmployeeM = new EmployeeManagement();
            EmployeeM.ShowDialog();
            this.Close();
        }

        private void TileButtonInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarInforManagement InforM = new CarInforManagement();
            InforM.ShowDialog();
            this.Close();
        }
    }
}
