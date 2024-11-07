namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxNroCta = new System.Windows.Forms.CheckBox();
            this.txbCtaCte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPago = new System.Windows.Forms.RadioButton();
            this.rbtnCompra = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtender
            // 
            this.btnAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.Location = new System.Drawing.Point(188, 305);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(148, 52);
            this.btnAtender.TabIndex = 16;
            this.btnAtender.Text = "Atender Cliente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(342, 244);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(89, 52);
            this.btnImportar.TabIndex = 14;
            this.btnImportar.Text = "Importar Cta Ctes";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(342, 188);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(89, 50);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(342, 58);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(89, 80);
            this.btnTicket.TabIndex = 12;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 108);
            this.listBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turnos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxNroCta);
            this.panel1.Controls.Add(this.txbCtaCte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 75);
            this.panel1.TabIndex = 9;
            // 
            // cbxNroCta
            // 
            this.cbxNroCta.AutoSize = true;
            this.cbxNroCta.Location = new System.Drawing.Point(22, 47);
            this.cbxNroCta.Name = "cbxNroCta";
            this.cbxNroCta.Size = new System.Drawing.Size(81, 17);
            this.cbxNroCta.TabIndex = 11;
            this.cbxNroCta.Text = "Nro Cta Cte";
            this.cbxNroCta.UseVisualStyleBackColor = true;
            // 
            // txbCtaCte
            // 
            this.txbCtaCte.Location = new System.Drawing.Point(140, 45);
            this.txbCtaCte.Name = "txbCtaCte";
            this.txbCtaCte.Size = new System.Drawing.Size(129, 20);
            this.txbCtaCte.TabIndex = 9;
            this.txbCtaCte.Text = "CtaCte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // rbtnPago
            // 
            this.rbtnPago.AutoSize = true;
            this.rbtnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPago.Location = new System.Drawing.Point(16, 31);
            this.rbtnPago.Name = "rbtnPago";
            this.rbtnPago.Size = new System.Drawing.Size(61, 22);
            this.rbtnPago.TabIndex = 12;
            this.rbtnPago.TabStop = true;
            this.rbtnPago.Text = "Pago";
            this.rbtnPago.UseVisualStyleBackColor = true;
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCompra.Location = new System.Drawing.Point(16, 3);
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Size = new System.Drawing.Size(80, 22);
            this.rbtnCompra.TabIndex = 11;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "Compra";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnCompra);
            this.panel2.Controls.Add(this.rbtnPago);
            this.panel2.Location = new System.Drawing.Point(15, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 60);
            this.panel2.TabIndex = 12;
            // 
            // txbDNI
            // 
            this.txbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDNI.Location = new System.Drawing.Point(107, 23);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(129, 24);
            this.txbDNI.TabIndex = 17;
            this.txbDNI.Text = "DNI";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(54, 25);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(37, 20);
            this.lbDNI.TabIndex = 12;
            this.lbDNI.Text = "DNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 372);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txbCtaCte;
        private System.Windows.Forms.RadioButton rbtnPago;
        private System.Windows.Forms.RadioButton rbtnCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxNroCta;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.Label lbDNI;
    }
}

