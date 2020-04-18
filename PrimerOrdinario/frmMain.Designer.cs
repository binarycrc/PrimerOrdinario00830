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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabOrdinario.SuspendLayout();
            this.tabDivision.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrdinario
            // 
            this.tabOrdinario.Controls.Add(this.tabPage1);
            this.tabOrdinario.Controls.Add(this.tabDivision);
            this.tabOrdinario.Location = new System.Drawing.Point(12, 120);
            this.tabOrdinario.Name = "tabOrdinario";
            this.tabOrdinario.SelectedIndex = 0;
            this.tabOrdinario.Size = new System.Drawing.Size(858, 343);
            this.tabOrdinario.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Text = "groupBox1";
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
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(11, 26);
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
            this.btnDividir.TabIndex = 12;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(210, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(88, 71);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(88, 45);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 9;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(88, 19);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 8;
            // 
            // lblOrdinarioI
            // 
            this.lblOrdinarioI.AutoSize = true;
            this.lblOrdinarioI.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinarioI.Location = new System.Drawing.Point(320, 24);
            this.lblOrdinarioI.Name = "lblOrdinarioI";
            this.lblOrdinarioI.Size = new System.Drawing.Size(154, 36);
            this.lblOrdinarioI.TabIndex = 10;
            this.lblOrdinarioI.Text = "Ordinario I";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 557);
            this.Controls.Add(this.lblOrdinarioI);
            this.Controls.Add(this.tabOrdinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabOrdinario.ResumeLayout(false);
            this.tabDivision.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrdinario;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}

