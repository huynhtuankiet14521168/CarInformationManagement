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
    public partial class CarInforManagement : Form
    {
        public CarInforManagement()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator Cancel = new Administrator();
            Cancel.ShowDialog();
            this.Close();
        }
    }
}
