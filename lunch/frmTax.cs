using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lunch
{
    public partial class frmTax : Form
    {
        public frmTax()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Tag = textBox1.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double t;
            bool isNum = double.TryParse(textBox1.Text, out t);

            if (!isNum || t < 0 || t > 100)
            {
                MessageBox.Show("Enter a value between 0 and 100.");
            }
            else
            {
                this.Tag = textBox1.Text;
            }
        }

        private void frmTax_Load(object sender, EventArgs e)
        {
            textBox1.Text = (7.75).ToString();
        }
    }
}
