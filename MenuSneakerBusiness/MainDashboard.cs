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
using System.Diagnostics;

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
            buttonInventory.BackColor = ColorTranslator.FromHtml("#c0d3fe");
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
            buttonConsignment.BackColor = ColorTranslator.FromHtml("#c0d3fe");
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
            buttonPOS.BackColor = ColorTranslator.FromHtml("#c0d3fe");
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
            buttonFinancial.BackColor = ColorTranslator.FromHtml("#c0d3fe");
            pictureBoxCurrentForm.Image = Properties.Resources.icons8_graph_report_50;
            currentForm.Text = buttonFinancial.Text;
            panelContents.Controls.Clear();
            Financial financial = new Financial();
            financial.Dock = DockStyle.Fill;
            panelContents.Controls.Add(financial);
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

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/18000157500adrian/"; //FACEBOOK PAGE OF THE BUSINESS
            openUrlInChrome(url);
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/janreintan"; //INSTAGRAM PAGE OF THE BUSINESS
            openUrlInChrome(url);
        }

        private void pictureBoxMBS_Click(object sender, EventArgs e)
        {
            string url = "https://business.facebook.com/"; //META BUSINESS SUITE OF THE BUSINESS TO ANSWER INQUIRIES OF BOTH FB AND IG
            openUrlInChrome(url);
        }
        public void openUrlInChrome(string url)
        {
            string chromePath = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"; //EDIT THIS IF YOUR CHROME IS IN ANOTHER FILE PATH.
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = chromePath;
            psi.Arguments = url;
            Process.Start(psi);
        }
        private void SetButtonPropertiesLeave(Button button)
        {
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(25, 0, 0, 0);
        }
        private void SetButtonPropertiesEnter(Button button)
        {
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.TextAlign = ContentAlignment.MiddleRight;
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.Padding = new Padding(0, 0, 25, 0);
        }
        private void buttonInventory_MouseLeave(object sender, EventArgs e)
        {
            SetButtonPropertiesLeave(buttonInventory);
        }
        private void buttonInventory_MouseEnter(object sender, EventArgs e)
        {
            SetButtonPropertiesEnter(buttonInventory);
        }
        private void buttonConsignment_MouseEnter(object sender, EventArgs e)
        {
            SetButtonPropertiesEnter(buttonConsignment);
        }
        private void buttonConsignment_MouseLeave(object sender, EventArgs e)
        {
            SetButtonPropertiesLeave(buttonConsignment);
        }
        private void buttonPOS_MouseEnter(object sender, EventArgs e)
        {
            SetButtonPropertiesEnter(buttonPOS);
        }
        private void buttonFinancial_MouseEnter(object sender, EventArgs e)
        {
            SetButtonPropertiesEnter(buttonFinancial);
        }
        private void buttonFinancial_MouseLeave(object sender, EventArgs e)
        {
            SetButtonPropertiesLeave(buttonFinancial);
        }
        private void buttonPOS_MouseLeave(object sender, EventArgs e)
        {
            SetButtonPropertiesLeave(buttonPOS);
        }


        private void pictureBoxInstagram_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInstagram.Image = Properties.Resources.icons8_instagram_50__1_;
        }

        private void pictureBoxInstagram_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInstagram.Image = Properties.Resources.icons8_instagram_50;
        }

        private void pictureBoxFacebook_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFacebook.Image = Properties.Resources.icons8_facebook_50;
        }

        private void pictureBoxFacebook_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFacebook.Image = Properties.Resources.icons8_facebook_50__1_;
        }

        private void pictureBoxMBS_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMBS.Image = Properties.Resources.icons8_meta_50__1_;
        }

        private void pictureBoxMBS_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMBS.Image = Properties.Resources.icons8_meta_50;
        }

        private void pictureBoxMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_exit_50;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.icons8_exit_50__1_;
        }

        private void pictureBoxMaximized_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMaximized.Image = Properties.Resources.icons8_maximize_50;
        }

        private void pictureBoxMaximized_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMaximized.Image = Properties.Resources.icons8_maximize_50__1_;
        }

        private void pictureBoxMinimized_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMinimized.Image = Properties.Resources.icons8_minimize_window_50;
        }

        private void pictureBoxMinimized_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMinimized.Image = Properties.Resources.icons8_minimize_window_50__1_;
        }
    }
}
