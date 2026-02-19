namespace Presentacion
{
    partial class MiPrimerFormulario
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
            this.AniadirBoton = new System.Windows.Forms.Button();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.ReporteBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.SalirBoton = new System.Windows.Forms.Button();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.TbCuil = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaCaja = new System.Windows.Forms.ListBox();
            this.ListaCajaEmail = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.TbBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ListaCajaNombre = new System.Windows.Forms.ListBox();
            this.ListaCajaPDF = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AniadirBoton
            // 
            this.AniadirBoton.Location = new System.Drawing.Point(35, 359);
            this.AniadirBoton.Margin = new System.Windows.Forms.Padding(4);
            this.AniadirBoton.Name = "AniadirBoton";
            this.AniadirBoton.Size = new System.Drawing.Size(163, 60);
            this.AniadirBoton.TabIndex = 0;
            this.AniadirBoton.Text = "Añadir";
            this.AniadirBoton.UseVisualStyleBackColor = true;
            this.AniadirBoton.Click += new System.EventHandler(this.AniadirBoton_Click);
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.Location = new System.Drawing.Point(205, 359);
            this.ActualizarBoton.Margin = new System.Windows.Forms.Padding(4);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(163, 60);
            this.ActualizarBoton.TabIndex = 1;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = true;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // ReporteBoton
            // 
            this.ReporteBoton.Location = new System.Drawing.Point(547, 359);
            this.ReporteBoton.Margin = new System.Windows.Forms.Padding(4);
            this.ReporteBoton.Name = "ReporteBoton";
            this.ReporteBoton.Size = new System.Drawing.Size(163, 60);
            this.ReporteBoton.TabIndex = 3;
            this.ReporteBoton.Text = "Descargar CSV";
            this.ReporteBoton.UseVisualStyleBackColor = true;
            this.ReporteBoton.Click += new System.EventHandler(this.ReporteBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(376, 359);
            this.EliminarBoton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(163, 60);
            this.EliminarBoton.TabIndex = 2;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // SalirBoton
            // 
            this.SalirBoton.Location = new System.Drawing.Point(717, 359);
            this.SalirBoton.Margin = new System.Windows.Forms.Padding(4);
            this.SalirBoton.Name = "SalirBoton";
            this.SalirBoton.Size = new System.Drawing.Size(163, 60);
            this.SalirBoton.TabIndex = 4;
            this.SalirBoton.Text = "Salir";
            this.SalirBoton.UseVisualStyleBackColor = true;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.codigoLabel.Location = new System.Drawing.Point(46, 40);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(29, 16);
            this.codigoLabel.TabIndex = 5;
            this.codigoLabel.Text = "Cuil";
            // 
            // TbCuil
            // 
            this.TbCuil.Location = new System.Drawing.Point(82, 34);
            this.TbCuil.Margin = new System.Windows.Forms.Padding(4);
            this.TbCuil.Name = "TbCuil";
            this.TbCuil.Size = new System.Drawing.Size(132, 22);
            this.TbCuil.TabIndex = 6;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(82, 72);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(283, 22);
            this.TbNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 41);
            this.label2.TabIndex = 9;
            // 
            // ListaCaja
            // 
            this.ListaCaja.FormattingEnabled = true;
            this.ListaCaja.ItemHeight = 16;
            this.ListaCaja.Location = new System.Drawing.Point(434, 92);
            this.ListaCaja.Margin = new System.Windows.Forms.Padding(4);
            this.ListaCaja.Name = "ListaCaja";
            this.ListaCaja.Size = new System.Drawing.Size(105, 228);
            this.ListaCaja.TabIndex = 10;
            this.ListaCaja.SelectedIndexChanged += new System.EventHandler(this.ListaCaja_SelectedIndexChanged);
            // 
            // ListaCajaEmail
            // 
            this.ListaCajaEmail.FormattingEnabled = true;
            this.ListaCajaEmail.ItemHeight = 16;
            this.ListaCajaEmail.Location = new System.Drawing.Point(660, 92);
            this.ListaCajaEmail.Margin = new System.Windows.Forms.Padding(4);
            this.ListaCajaEmail.Name = "ListaCajaEmail";
            this.ListaCajaEmail.Size = new System.Drawing.Size(126, 228);
            this.ListaCajaEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(431, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cuil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(544, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarBoton);
            this.groupBox1.Controls.Add(this.TbBusca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(35, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(389, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(273, 22);
            this.BuscarBoton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(108, 28);
            this.BuscarBoton.TabIndex = 21;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // TbBusca
            // 
            this.TbBusca.Location = new System.Drawing.Point(8, 23);
            this.TbBusca.Margin = new System.Windows.Forms.Padding(4);
            this.TbBusca.Name = "TbBusca";
            this.TbBusca.Size = new System.Drawing.Size(257, 22);
            this.TbBusca.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad de busquedas relacionadas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "0";
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(82, 115);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(283, 22);
            this.TbEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(26, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(40, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "PDF";
            // 
            // ListaCajaNombre
            // 
            this.ListaCajaNombre.FormattingEnabled = true;
            this.ListaCajaNombre.ItemHeight = 16;
            this.ListaCajaNombre.Location = new System.Drawing.Point(547, 92);
            this.ListaCajaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.ListaCajaNombre.Name = "ListaCajaNombre";
            this.ListaCajaNombre.Size = new System.Drawing.Size(105, 228);
            this.ListaCajaNombre.TabIndex = 24;
            // 
            // ListaCajaPDF
            // 
            this.ListaCajaPDF.FormattingEnabled = true;
            this.ListaCajaPDF.ItemHeight = 16;
            this.ListaCajaPDF.Location = new System.Drawing.Point(794, 94);
            this.ListaCajaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.ListaCajaPDF.Name = "ListaCajaPDF";
            this.ListaCajaPDF.Size = new System.Drawing.Size(126, 228);
            this.ListaCajaPDF.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(657, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(791, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Link PDF";
            // 
            // MiPrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListaCajaPDF);
            this.Controls.Add(this.ListaCajaNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaCajaEmail);
            this.Controls.Add(this.ListaCaja);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCuil);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.SalirBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.ReporteBoton);
            this.Controls.Add(this.ActualizarBoton);
            this.Controls.Add(this.AniadirBoton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MiPrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroCasa: Sistema de Gestion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AniadirBoton;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.Button ReporteBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button SalirBoton;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox TbCuil;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListaCaja;
        private System.Windows.Forms.ListBox ListaCajaEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.TextBox TbBusca;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListaCajaNombre;
        private System.Windows.Forms.ListBox ListaCajaPDF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}