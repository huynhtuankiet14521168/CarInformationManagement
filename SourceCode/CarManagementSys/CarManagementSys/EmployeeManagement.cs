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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator Cancel = new Administrator();
            Cancel.ShowDialog();
            this.Close();
        }
    }
}
