using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSneakerBusiness
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            panelContents.Controls.Clear();
            Inventory inventory = new Inventory();
            inventory.Dock = DockStyle.Fill;
            panelContents.Controls.Add(inventory);
        }

        private void buttonConsignment_Click(object sender, EventArgs e)
        {
            Consignor consignor = new Consignor();
            consignor.ShowDialog();
        }
    }
}
