namespace PreParcial2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.rbtnNuevo = new System.Windows.Forms.RadioButton();
            this.rbtnDenuncia = new System.Windows.Forms.RadioButton();
            this.txbPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnDenuncia = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbDNI);
            this.panel1.Controls.Add(this.rbtnNuevo);
            this.panel1.Controls.Add(this.rbtnDenuncia);
            this.panel1.Controls.Add(this.txbPatente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 128);
            this.panel1.TabIndex = 1;
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(140, 83);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(129, 20);
            this.txbDNI.TabIndex = 9;
            this.txbDNI.Text = "DNI";
            // 
            // rbtnNuevo
            // 
            this.rbtnNuevo.AutoSize = true;
            this.rbtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNuevo.Location = new System.Drawing.Point(15, 80);
            this.rbtnNuevo.Name = "rbtnNuevo";
            this.rbtnNuevo.Size = new System.Drawing.Size(118, 22);
            this.rbtnNuevo.TabIndex = 12;
            this.rbtnNuevo.TabStop = true;
            this.rbtnNuevo.Text = "Nuevo Cliente";
            this.rbtnNuevo.UseVisualStyleBackColor = true;
            // 
            // rbtnDenuncia
            // 
            this.rbtnDenuncia.AutoSize = true;
            this.rbtnDenuncia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDenuncia.Location = new System.Drawing.Point(15, 51);
            this.rbtnDenuncia.Name = "rbtnDenuncia";
            this.rbtnDenuncia.Size = new System.Drawing.Size(88, 22);
            this.rbtnDenuncia.TabIndex = 11;
            this.rbtnDenuncia.TabStop = true;
            this.rbtnDenuncia.Text = "Denuncia";
            this.rbtnDenuncia.UseVisualStyleBackColor = true;
            // 
            // txbPatente
            // 
            this.txbPatente.Location = new System.Drawing.Point(140, 54);
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(129, 20);
            this.txbPatente.TabIndex = 10;
            this.txbPatente.Text = "ingresar patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turnos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 108);
            this.listBox1.TabIndex = 3;
            // 
            // btnTicket
            // 
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(341, 34);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(89, 80);
            this.btnTicket.TabIndex = 4;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(341, 188);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(89, 50);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(341, 244);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(89, 52);
            this.btnImportar.TabIndex = 6;
            this.btnImportar.Text = "Importar Tickets";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnDenuncia
            // 
            this.btnDenuncia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenuncia.Location = new System.Drawing.Point(12, 302);
            this.btnDenuncia.Name = "btnDenuncia";
            this.btnDenuncia.Size = new System.Drawing.Size(148, 52);
            this.btnDenuncia.TabIndex = 7;
            this.btnDenuncia.Text = "Atender Denuncia";
            this.btnDenuncia.UseVisualStyleBackColor = true;
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoC.Location = new System.Drawing.Point(187, 302);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(148, 52);
            this.btnNuevoC.TabIndex = 8;
            this.btnNuevoC.Text = "Atender Nuevo Cliente";
            this.btnNuevoC.UseVisualStyleBackColor = true;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevoC_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 370);
            this.Controls.Add(this.btnNuevoC);
            this.Controls.Add(this.btnDenuncia);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnDenuncia;
        private System.Windows.Forms.Button btnNuevoC;
        private System.Windows.Forms.RadioButton rbtnNuevo;
        private System.Windows.Forms.RadioButton rbtnDenuncia;
        private System.Windows.Forms.TextBox txbPatente;
        public System.Windows.Forms.Button btnTicket;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

