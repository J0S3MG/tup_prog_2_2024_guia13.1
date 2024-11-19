namespace EjercicioRepaso
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
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.tbxPatente = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.rbnDenuncia = new System.Windows.Forms.RadioButton();
            this.rbnCliente = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAtenderC = new System.Windows.Forms.Button();
            this.btnAtenderD = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(52, 33);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(256, 22);
            this.tbxDNI.TabIndex = 0;
            // 
            // tbxPatente
            // 
            this.tbxPatente.Location = new System.Drawing.Point(124, 79);
            this.tbxPatente.Name = "tbxPatente";
            this.tbxPatente.Size = new System.Drawing.Size(184, 22);
            this.tbxPatente.TabIndex = 1;
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Auto",
            "Moto",
            "Equipo de trabajo",
            "Bicicleta"});
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Equipo de Trabajo",
            "Bicicleta"});
            this.cbxTipo.Location = new System.Drawing.Point(124, 120);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(184, 24);
            this.cbxTipo.TabIndex = 2;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(339, 20);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(111, 135);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // rbnDenuncia
            // 
            this.rbnDenuncia.AutoSize = true;
            this.rbnDenuncia.Location = new System.Drawing.Point(12, 77);
            this.rbnDenuncia.Name = "rbnDenuncia";
            this.rbnDenuncia.Size = new System.Drawing.Size(85, 20);
            this.rbnDenuncia.TabIndex = 4;
            this.rbnDenuncia.TabStop = true;
            this.rbnDenuncia.Text = "Denuncia";
            this.rbnDenuncia.UseVisualStyleBackColor = true;
            // 
            // rbnCliente
            // 
            this.rbnCliente.AutoSize = true;
            this.rbnCliente.Location = new System.Drawing.Point(15, 121);
            this.rbnCliente.Name = "rbnCliente";
            this.rbnCliente.Size = new System.Drawing.Size(69, 20);
            this.rbnCliente.TabIndex = 5;
            this.rbnCliente.TabStop = true;
            this.rbnCliente.Text = "Cliente";
            this.rbnCliente.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 148);
            this.listBox1.TabIndex = 6;
            // 
            // btnAtenderC
            // 
            this.btnAtenderC.Location = new System.Drawing.Point(207, 315);
            this.btnAtenderC.Name = "btnAtenderC";
            this.btnAtenderC.Size = new System.Drawing.Size(190, 88);
            this.btnAtenderC.TabIndex = 7;
            this.btnAtenderC.Text = "Atender Cliente";
            this.btnAtenderC.UseVisualStyleBackColor = true;
            this.btnAtenderC.Click += new System.EventHandler(this.btnAtenderC_Click);
            // 
            // btnAtenderD
            // 
            this.btnAtenderD.Location = new System.Drawing.Point(15, 315);
            this.btnAtenderD.Name = "btnAtenderD";
            this.btnAtenderD.Size = new System.Drawing.Size(186, 88);
            this.btnAtenderD.TabIndex = 8;
            this.btnAtenderD.Text = "Atender Denuncia";
            this.btnAtenderD.UseVisualStyleBackColor = true;
            this.btnAtenderD.Click += new System.EventHandler(this.btnAtenderD_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(420, 171);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(112, 82);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(420, 279);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(112, 82);
            this.btnImportar.TabIndex = 10;
            this.btnImportar.Text = "Importar Vehiculo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 417);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAtenderD);
            this.Controls.Add(this.btnAtenderC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbnCliente);
            this.Controls.Add(this.rbnDenuncia);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.tbxPatente);
            this.Controls.Add(this.tbxDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.TextBox tbxPatente;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.RadioButton rbnDenuncia;
        private System.Windows.Forms.RadioButton rbnCliente;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAtenderC;
        private System.Windows.Forms.Button btnAtenderD;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
    }
}

