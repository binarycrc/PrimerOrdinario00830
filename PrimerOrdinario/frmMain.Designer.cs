namespace PrimerOrdinario
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOrdinario = new System.Windows.Forms.TabControl();
            this.tabMatriz = new System.Windows.Forms.TabPage();
            this.tabDivision = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblOrdinarioI = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiaMatriz = new System.Windows.Forms.Button();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.gvMatriz = new System.Windows.Forms.DataGridView();
            this.tabOrdinario.SuspendLayout();
            this.tabMatriz.SuspendLayout();
            this.tabDivision.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOrdinario
            // 
            this.tabOrdinario.Controls.Add(this.tabMatriz);
            this.tabOrdinario.Controls.Add(this.tabDivision);
            this.tabOrdinario.Location = new System.Drawing.Point(12, 63);
            this.tabOrdinario.Name = "tabOrdinario";
            this.tabOrdinario.SelectedIndex = 0;
            this.tabOrdinario.Size = new System.Drawing.Size(639, 292);
            this.tabOrdinario.TabIndex = 9;
            // 
            // tabMatriz
            // 
            this.tabMatriz.Controls.Add(this.groupBox2);
            this.tabMatriz.Location = new System.Drawing.Point(4, 22);
            this.tabMatriz.Name = "tabMatriz";
            this.tabMatriz.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatriz.Size = new System.Drawing.Size(631, 266);
            this.tabMatriz.TabIndex = 0;
            this.tabMatriz.Text = "Matriz";
            this.tabMatriz.UseVisualStyleBackColor = true;
            // 
            // tabDivision
            // 
            this.tabDivision.Controls.Add(this.groupBox1);
            this.tabDivision.Location = new System.Drawing.Point(4, 22);
            this.tabDivision.Name = "tabDivision";
            this.tabDivision.Padding = new System.Windows.Forms.Padding(3);
            this.tabDivision.Size = new System.Drawing.Size(850, 317);
            this.tabDivision.TabIndex = 1;
            this.tabDivision.Text = "Division";
            this.tabDivision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDivisor);
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.txtDividendo);
            this.groupBox1.Controls.Add(this.txtDivisor);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(11, 48);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 13;
            this.lblDivisor.Text = "Divisor:";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(210, 69);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(210, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(88, 71);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.TabStop = false;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(88, 19);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 9;
            this.txtDividendo.TextChanged += new System.EventHandler(this.txtDividendo_TextChanged);
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(88, 45);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 10;
            this.txtDivisor.TextChanged += new System.EventHandler(this.txtDivisor_TextChanged);
            // 
            // lblOrdinarioI
            // 
            this.lblOrdinarioI.AutoSize = true;
            this.lblOrdinarioI.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinarioI.Location = new System.Drawing.Point(223, 24);
            this.lblOrdinarioI.Name = "lblOrdinarioI";
            this.lblOrdinarioI.Size = new System.Drawing.Size(154, 36);
            this.lblOrdinarioI.TabIndex = 10;
            this.lblOrdinarioI.Text = "Ordinario I";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvMatriz);
            this.groupBox2.Controls.Add(this.lblFilas);
            this.groupBox2.Controls.Add(this.lblColumnas);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnLimpiaMatriz);
            this.groupBox2.Controls.Add(this.txtFilas);
            this.groupBox2.Controls.Add(this.txtColumnas);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 252);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(6, 16);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(31, 13);
            this.lblFilas.TabIndex = 14;
            this.lblFilas.Text = "Filas:";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(6, 55);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(56, 13);
            this.lblColumnas.TabIndex = 13;
            this.lblColumnas.Text = "Columnas:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(9, 127);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiaMatriz
            // 
            this.btnLimpiaMatriz.Location = new System.Drawing.Point(9, 98);
            this.btnLimpiaMatriz.Name = "btnLimpiaMatriz";
            this.btnLimpiaMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiaMatriz.TabIndex = 12;
            this.btnLimpiaMatriz.Text = "Limpiar";
            this.btnLimpiaMatriz.UseVisualStyleBackColor = true;
            this.btnLimpiaMatriz.Click += new System.EventHandler(this.btnLimpiaMatriz_Click);
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(9, 32);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(100, 20);
            this.txtFilas.TabIndex = 9;
            this.txtFilas.TextChanged += new System.EventHandler(this.txtFilas_TextChanged);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(9, 72);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 20);
            this.txtColumnas.TabIndex = 10;
            this.txtColumnas.TextChanged += new System.EventHandler(this.txtColumnas_TextChanged);
            // 
            // gvMatriz
            // 
            this.gvMatriz.AllowUserToAddRows = false;
            this.gvMatriz.AllowUserToDeleteRows = false;
            this.gvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMatriz.Location = new System.Drawing.Point(133, 16);
            this.gvMatriz.Name = "gvMatriz";
            this.gvMatriz.ReadOnly = true;
            this.gvMatriz.Size = new System.Drawing.Size(477, 230);
            this.gvMatriz.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 365);
            this.Controls.Add(this.lblOrdinarioI);
            this.Controls.Add(this.tabOrdinario);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer Ordinario Pablo Ugalde";
            this.tabOrdinario.ResumeLayout(false);
            this.tabMatriz.ResumeLayout(false);
            this.tabDivision.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrdinario;
        private System.Windows.Forms.TabPage tabMatriz;
        private System.Windows.Forms.TabPage tabDivision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblOrdinarioI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpiaMatriz;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.DataGridView gvMatriz;
    }
}

