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
            //buttonInventory.ForeColor = ColorTranslator.FromHtml("#280137");
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
        private void buttonInventory_MouseLeave(object sender, EventArgs e)
        {
            buttonInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventory.Padding = new Padding(25, 0, 0, 0);
        }
        private void buttonInventory_MouseEnter(object sender, EventArgs e)
        {
            buttonInventory.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonInventory.TextAlign = ContentAlignment.MiddleRight;
            buttonInventory.ImageAlign = ContentAlignment.MiddleRight;
            buttonInventory.Padding = new Padding(0, 0, 25, 0);
        }
        private void buttonConsignment_MouseEnter(object sender, EventArgs e)
        {
            buttonConsignment.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonConsignment.TextAlign = ContentAlignment.MiddleRight;
            buttonConsignment.ImageAlign = ContentAlignment.MiddleRight;
            buttonConsignment.Padding = new Padding(0, 0, 25, 0);
        }
        private void buttonConsignment_MouseLeave(object sender, EventArgs e)
        {
            buttonConsignment.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsignment.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsignment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsignment.Padding = new Padding(25, 0, 0, 0);
        }
        private void buttonPOS_MouseEnter(object sender, EventArgs e)
        {
            buttonPOS.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonPOS.TextAlign = ContentAlignment.MiddleRight;
            buttonPOS.ImageAlign = ContentAlignment.MiddleRight;
            buttonPOS.Padding = new Padding(0, 0, 25, 0);
        }
        private void buttonFinancial_MouseEnter(object sender, EventArgs e)
        {
            buttonFinancial.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonFinancial.TextAlign = ContentAlignment.MiddleRight;
            buttonFinancial.ImageAlign = ContentAlignment.MiddleRight;
            buttonFinancial.Padding = new Padding(0, 0, 25, 0);
        }
        private void buttonFinancial_MouseLeave(object sender, EventArgs e)
        {
            buttonFinancial.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFinancial.TextAlign = ContentAlignment.MiddleLeft;
            buttonFinancial.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinancial.Padding = new Padding(25, 0, 0, 0);
        }
        private void buttonPOS_MouseLeave(object sender, EventArgs e)
        {
            buttonPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPOS.TextAlign = ContentAlignment.MiddleLeft;
            buttonPOS.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPOS.Padding = new Padding(25, 0, 0, 0);
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //CONTINUE
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
