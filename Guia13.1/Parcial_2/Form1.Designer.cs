namespace Parcial_2
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
            this.components = new System.ComponentModel.Container();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxNroCtaCte = new System.Windows.Forms.TextBox();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.cbxNroCtaCte = new System.Windows.Forms.CheckBox();
            this.rbxPago = new System.Windows.Forms.RadioButton();
            this.rbxCliente = new System.Windows.Forms.RadioButton();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(33, 22);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(162, 22);
            this.tbxDNI.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxNroCtaCte
            // 
            this.tbxNroCtaCte.Location = new System.Drawing.Point(134, 72);
            this.tbxNroCtaCte.Name = "tbxNroCtaCte";
            this.tbxNroCtaCte.Size = new System.Drawing.Size(162, 22);
            this.tbxNroCtaCte.TabIndex = 2;
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.ItemHeight = 16;
            this.lbxTurnos.Location = new System.Drawing.Point(33, 105);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(263, 244);
            this.lbxTurnos.TabIndex = 3;
            // 
            // cbxNroCtaCte
            // 
            this.cbxNroCtaCte.AutoSize = true;
            this.cbxNroCtaCte.Location = new System.Drawing.Point(33, 74);
            this.cbxNroCtaCte.Name = "cbxNroCtaCte";
            this.cbxNroCtaCte.Size = new System.Drawing.Size(95, 20);
            this.cbxNroCtaCte.TabIndex = 4;
            this.cbxNroCtaCte.Text = "checkBox1";
            this.cbxNroCtaCte.UseVisualStyleBackColor = true;
            // 
            // rbxPago
            // 
            this.rbxPago.AutoSize = true;
            this.rbxPago.Location = new System.Drawing.Point(193, 383);
            this.rbxPago.Name = "rbxPago";
            this.rbxPago.Size = new System.Drawing.Size(68, 20);
            this.rbxPago.TabIndex = 5;
            this.rbxPago.TabStop = true;
            this.rbxPago.Text = "Pagos";
            this.rbxPago.UseVisualStyleBackColor = true;
            // 
            // rbxCliente
            // 
            this.rbxCliente.AutoSize = true;
            this.rbxCliente.Location = new System.Drawing.Point(193, 350);
            this.rbxCliente.Name = "rbxCliente";
            this.rbxCliente.Size = new System.Drawing.Size(69, 20);
            this.rbxCliente.TabIndex = 6;
            this.rbxCliente.TabStop = true;
            this.rbxCliente.Text = "Cliente";
            this.rbxCliente.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(319, 8);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(165, 86);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(319, 113);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(165, 86);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(319, 215);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(165, 86);
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "Importar Ctas Ctes";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(319, 317);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(165, 86);
            this.btnAtender.TabIndex = 10;
            this.btnAtender.Text = "Atender Turnos";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.rbxCliente);
            this.Controls.Add(this.rbxPago);
            this.Controls.Add(this.cbxNroCtaCte);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.tbxNroCtaCte);
            this.Controls.Add(this.tbxDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbxNroCtaCte;
        private System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.CheckBox cbxNroCtaCte;
        private System.Windows.Forms.RadioButton rbxPago;
        private System.Windows.Forms.RadioButton rbxCliente;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtender;
    }
}

