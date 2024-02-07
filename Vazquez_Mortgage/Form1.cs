using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vazquez_Mortgage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Principal = decimal.Parse(txtprincipal.Text);

            if (rdo15year.Select == 0)
            {

            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtprincipal.Text = string.Empty;
            //rdo15year.
            cboInterest.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
