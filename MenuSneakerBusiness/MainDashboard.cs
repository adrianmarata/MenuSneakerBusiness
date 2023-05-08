using Microsoft.VisualBasic.ApplicationServices;
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
            buttonPOS.BackColor = Color.Transparent;
            buttonFinancial.BackColor = Color.Transparent;
            buttonConsignment.BackColor = Color.Transparent;
            buttonInventory.BackColor = Color.FromArgb(255, 128, 0);
            pictureBoxCurrentForm.Image = Properties.Resources.icons8_open_box_50;
            currentForm.Text = buttonInventory.Text;
            panelContents.Controls.Clear();
            Inventory inventory = new Inventory();
            inventory.Dock = DockStyle.Fill;
            panelContents.Controls.Add(inventory);
        }

        private void buttonConsignment_Click(object sender, EventArgs e)
        {
            buttonPOS.BackColor = Color.Transparent;
            buttonInventory.BackColor = Color.Transparent;
            buttonFinancial.BackColor = Color.Transparent;
            buttonConsignment.BackColor = Color.FromArgb(255, 128, 0);
            pictureBoxCurrentForm.Image = Properties.Resources.icons8_consignment_50;
            currentForm.Text = buttonConsignment.Text;
            panelContents.Controls.Clear();
            Consignment consignment = new Consignment();
            consignment.Dock = DockStyle.Fill;
            panelContents.Controls.Add(consignment);
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            buttonInventory.BackColor = Color.Transparent;
            buttonConsignment.BackColor = Color.Transparent;
            buttonFinancial.BackColor = Color.Transparent;
            buttonPOS.BackColor = Color.FromArgb(255, 128, 0);
            pictureBoxCurrentForm.Image = Properties.Resources.icons8_receipt_50;
            currentForm.Text = buttonPOS.Text;
            panelContents.Controls.Clear();
            PointOfSale pos = new PointOfSale();
            pos.Dock = DockStyle.Fill;
            panelContents.Controls.Add(pos);
        }

        private void buttonFinancial_Click(object sender, EventArgs e)
        {
            buttonInventory.BackColor = Color.Transparent;
            buttonConsignment.BackColor = Color.Transparent;
            buttonPOS.BackColor = Color.Transparent;
            buttonFinancial.BackColor = Color.FromArgb(255, 128, 0);
            pictureBoxCurrentForm.Image = Properties.Resources.icons8_graph_report_50;
            currentForm.Text = buttonFinancial.Text;
            panelContents.Controls.Clear();
            Financial financial = new Financial();
            financial.Dock = DockStyle.Fill;
            panelContents.Controls.Add(financial);
        }
    }
}
