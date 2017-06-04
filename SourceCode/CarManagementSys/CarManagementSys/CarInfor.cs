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
    public partial class CarInfor : Form
    {
        public CarInfor()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest Fn = new Guest();
            Fn.ShowDialog();
            this.Close();
        }
    }
}
