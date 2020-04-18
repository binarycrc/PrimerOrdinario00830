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
            catch (Exception)
            {
                numResult = false;
            }
            return numResult;
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            if (checkTextisNumber(txtDivisor.Text)){correctNum = txtDivisor.Text;}
            else{txtDivisor.Text = correctNum;  }
        }

        private void txtDividendo_TextChanged(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            if (checkTextisNumber(txtDividendo.Text)) { correctNum = txtDividendo.Text; }
            else { txtDividendo.Text = correctNum;  }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDivisor.Text = "";
            txtDividendo.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string msgAlert = "";
            try
            {
                if ((!string.IsNullOrWhiteSpace(txtDivisor.Text)) && (!string.IsNullOrWhiteSpace(txtDividendo.Text)))
                {
                    if (Convert.ToDouble(txtDivisor.Text) == 0)
                    {
                        msgAlert = "Divisor\r\n no pueden ser 0.";
                    }
                    else
                    {
                        Division division = new Division();
                        division.dDivisor = Convert.ToDouble(txtDivisor.Text);
                        division.dDividendo = Convert.ToDouble(txtDividendo.Text);
                        txtResultado.Text = division.dResultado.ToString();
                    }
                }
                else { msgAlert = "Divisor y Dividendo\r\n no pueden ser valores nulos o vacios."; }
            }
            catch (Exception ex)
            {
                msgAlert = ex.Message;
            }
            if (msgAlert != "")
            {
                MessageBox.Show(msgAlert, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
