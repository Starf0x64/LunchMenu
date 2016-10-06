using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lunch
{
    public partial class frmLunch : Form
    {

        Decimal taxRate = 7.75m;

        public frmLunch()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            frmTax myTax = new frmTax();
            DialogResult result = myTax.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblTax.Text = "Tax (" + Convert.ToString(myTax.Tag) + "%):";
                taxRate = Convert.ToDecimal(myTax.Tag);
                btnPlace.PerformClick();
            }
            
            //if(result == DialogResult.Cancel)            
                //label1.Text = Convert.ToString(myTax.Tag);
            
        }

        private void rdoBurger_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOn.Text = "Add-on Items ($.75/ea)";
            cb1.Text = "Lettuce, Tomato, Onion";
            cb2.Text = "Ketchup, Mustard, Mayo";
            cb3.Text = "Fries";
            clearAddons();
            clearTotals();
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOn.Text = "Add-on Items ($.50/ea)";
            cb1.Text = "Pepperoni";
            cb2.Text = "Sausage";
            cb3.Text = "Bacon";
            clearAddons();
            clearTotals();
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOn.Text = "Add-on Items ($.25/ea)";
            cb1.Text = "Croutons";
            cb2.Text = "Bacon";
            cb3.Text = "Bread Sticks";
            clearAddons();
            clearTotals();
        }

        private void clearAddons()
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
        }

        private void clearTotals()
        {
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            decimal total = 0.00m;

            if (rdoBurger.Checked)
            {
                total += 6.95m;

                if (cb1.Checked)
                    total += .75m;
                if (cb2.Checked)
                    total += .75m;
                if (cb3.Checked)
                    total += .75m;
            }
            else if (rdoPizza.Checked)
            {
                total += 5.95m;

                if (cb1.Checked)
                    total += .5m;
                if (cb2.Checked)
                    total += .5m;
                if (cb3.Checked)
                    total += .5m;
            }
            else if (rdoSalad.Checked)
            {
                total += 4.95m;

                if (cb1.Checked)
                    total += .25m;
                if (cb2.Checked)
                    total += .25m;
                if (cb3.Checked)
                    total += .25m;
            }

            txtSubtotal.Text = total.ToString("C2");
            txtTax.Text = (total * (taxRate/100)).ToString("C2");
            txtTotal.Text = (total + (total * (taxRate / 100))).ToString("C2");

        }

        private void frmLunch_Load(object sender, EventArgs e)
        {
            lblTax.Text = "Tax (" + Convert.ToString(taxRate) + "%):";
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
        }

        private void cb2_CheckedChanged_1(object sender, EventArgs e)
        {
            clearTotals();
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
        }
    }
}
