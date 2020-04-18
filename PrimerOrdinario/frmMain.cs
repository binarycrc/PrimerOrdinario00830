using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerOrdinario
{
    public partial class frmMain : Form
    {
        public static bool numResult;
        string correctNum;
        public frmMain()
        {
            InitializeComponent();
        }

        public static bool checkTextisNumber(string numberVal)
        {
            try
            {
                if (numberVal.Equals(".")){numResult = true;}
                else if (numberVal.Equals("")){numResult = true;}
                else{
                    decimal number3 = 0;
                    bool canConvert = decimal.TryParse(numberVal, out number3);
                    if (canConvert == true) { numResult = true; }
                    else { numResult = false; }
                }

            }
            catch (Exception ex)
            {
                numResult = false;
            }
            return numResult;
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {
            if (checkTextisNumber(txtDivisor.Text)){correctNum = txtDivisor.Text;}
            else{txtDivisor.Text = correctNum;}
        }

        private void txtDividendo_TextChanged(object sender, EventArgs e)
        {
            if (checkTextisNumber(txtDividendo.Text)) { correctNum = txtDividendo.Text; }
            else { txtDividendo.Text = correctNum; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDivisor.Text = "";
            txtDividendo.Text = "";
        }
    }
}
