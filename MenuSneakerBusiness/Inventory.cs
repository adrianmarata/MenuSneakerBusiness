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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            addItem addItem = new addItem();
            addItem.ShowDialog();
        }
    }
}
