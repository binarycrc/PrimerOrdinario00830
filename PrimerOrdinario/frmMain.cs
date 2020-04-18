/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/

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
        /// <summary>
        /// Declaracion de variables generales
        /// </summary>
        public static bool numResult; //Resultado de la validacion 
        string correctNum; //numero valido resultado de la validacion
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para validar cada entrada de los textbox
        /// para valores tipo Double (numeros y un punto)
        /// </summary>
        /// <param name="numberVal"></param>
        /// <returns>retorna verdadero si el digito es valido</returns>
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
        /// <summary>
        /// Metodo para validar cada entrada de los textbox
        /// para valores tipo Integer (numeros unicamente)
        /// </summary>
        /// <param name="numberVal"></param>
        /// <returns>retorna verdadero si el digito es valido</returns>
        public static bool checkTextisInt(string numberVal)
        {
            try
            {

                if(numberVal.Equals("")) { numResult = true; }
                else
                {
                    if (numberVal.Contains(".")) { numResult = false; }
                    else {
                        decimal number3 = 0;
                        bool canConvert = decimal.TryParse(numberVal, out number3);
                        if (canConvert == true) { numResult = true; }
                        else { numResult = false; }
                    }
                        
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
            //Limpiamos el textbox de resultado cuando cambian los valores del textbox divisor
            txtResultado.Text = ""; 
            //Si el texto ingresado en el textbox es invalido se remplaza 
            if (checkTextisNumber(txtDivisor.Text)){correctNum = txtDivisor.Text;}
            else{txtDivisor.Text = correctNum;  }
        }
        private void txtDividendo_TextChanged(object sender, EventArgs e)
        {
            //Limpiamos el textbox de resultado cuando cambian los valores del textbox dividendo
            txtResultado.Text = "";
            //Si el texto ingresado en el textbox es invalido se remplaza 
            if (checkTextisNumber(txtDividendo.Text)) { correctNum = txtDividendo.Text; }
            else { txtDividendo.Text = correctNum;  }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos los textbox 
            txtDivisor.Text = "";
            txtDividendo.Text = "";
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            string msgAlert = ""; //Variable para desplegar los mensajes
            try
            {
                //Se valida que los textbox no tengan valores en blanco
                if ((!string.IsNullOrWhiteSpace(txtDivisor.Text)) && (!string.IsNullOrWhiteSpace(txtDividendo.Text)))
                {
                    //Si el textbox divisor es 0 desplegamos el mensaje respectivo
                    if (Convert.ToDouble(txtDivisor.Text) == 0)
                    {
                        msgAlert = "Divisor\r\n no pueden ser 0.";
                    }
                    else
                    {
                        //creamos una instancia de la clase Division
                        Division division = new Division();
                        //asignamos valores a los atributos de la instancia
                        division.dDivisor = Convert.ToDouble(txtDivisor.Text);
                        division.dDividendo = Convert.ToDouble(txtDividendo.Text);
                        //Asigamos el valor de resultado de la division al textbox
                        txtResultado.Text = division.dResultado.ToString();
                    }
                }
                else { msgAlert = "Divisor y Dividendo\r\n no pueden ser valores nulos o vacios."; }
            }
            catch (DivideByZeroException ex) { msgAlert = ex.Message; }
            catch (Exception ex) {msgAlert = ex.Message;}
            if (msgAlert != "")
            {
                //si hay algun mensaje se muestra
                MessageBox.Show(msgAlert, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void txtFilas_TextChanged(object sender, EventArgs e)
        {
            //Si el texto ingresado en el textbox es invalido se remplaza 
            if (checkTextisInt(txtFilas.Text)) { correctNum = txtFilas.Text; }
            else { txtFilas.Text = correctNum; }
        }
        private void txtColumnas_TextChanged(object sender, EventArgs e)
        {
            //Si el texto ingresado en el textbox es invalido se remplaza 
            if (checkTextisInt(txtColumnas.Text)) { correctNum = txtColumnas.Text; }
            else { txtColumnas.Text = correctNum; }
        }
        private void btnLimpiaMatriz_Click(object sender, EventArgs e)
        {
            //Limpiamos los textbox
            txtColumnas.Text = "";
            txtFilas.Text = "";
            gvMatriz.Rows.Clear();
            gvMatriz.Refresh();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string msgAlert = ""; //Variable para desplegar los mensajes
            gvMatriz.Rows.Clear(); //Limpiamos el grid
            gvMatriz.Refresh();
            try
            {
                //Se valida que los textbox no tengan valores en blanco
                if ((!string.IsNullOrWhiteSpace(txtColumnas.Text)) && (!string.IsNullOrWhiteSpace(txtFilas.Text)))
                {
                    if (Convert.ToInt32(txtColumnas.Text)==0 || Convert.ToInt32(txtFilas.Text) == 0) 
                    {
                        msgAlert = "Filas y Columnas\r\n el valor tiene que ser mayor a 0.";
                    }
                    else 
                    {
                        //creamos la instancia matriz con los valores de filas y columnas previamente validados
                        Matriz matriz = new Matriz(Convert.ToInt32(txtFilas.Text), Convert.ToInt32(txtColumnas.Text));
                        //asignamos la cantidad de columnas al gridview para evitar errores
                        //asi el gridview y la matriz tienen el mismo tama;o
                        gvMatriz.ColumnCount = matriz.IntColumnas;

                        //recorrido del gridview segun los valores proporcionados
                        for (int r = 0; r < matriz.IntFilas; r++)
                        {
                            //creamos un row nuevo para ingresarlo en el gridview
                            DataGridViewRow row = new DataGridViewRow();
                            //creamos las celdas del row del gridview
                            row.CreateCells(gvMatriz);

                            for (int c = 0; c < matriz.IntColumnas; c++)
                            {
                                //asignamos el valor a la celda del grid 
                                //correspondiente a la misma posicion en la matriz
                                row.Cells[c].Value = matriz.Matrix(r, c);
                            }
                            //agregamos el row al gridview
                            gvMatriz.Rows.Add(row);
                        }
                    }
                }
                else { msgAlert = "Filas y Columnas\r\n no pueden ser valores nulos o vacios."; }
            }
            catch (Exception ex)
            {
                msgAlert = ex.Message;
            }
            if (msgAlert != "")
            {
                //si hay algun mensaje se muestra
                MessageBox.Show(msgAlert, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
