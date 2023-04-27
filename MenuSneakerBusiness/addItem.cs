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
    public partial class addItem : Form
    {
        public addItem()
        {
            InitializeComponent();
        }
        private void addItem_Load(object sender, EventArgs e)
        {
            comboBoxCondition.Items.Add("Brandnew");
            comboBoxCondition.Items.Add("Used");
        }
    }
}
