﻿namespace RepasoPruebaLista
{
    partial class RepasoLista
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
            btsalir = new Button();
            btcargar = new Button();
            txcnombreCarga = new TextBox();
            labellista = new Label();
            btmostrar = new Button();
            btlimpiar = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.Black;
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btsalir.ForeColor = SystemColors.Control;
            btsalir.Location = new Point(917, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // btcargar
            // 
            btcargar.BackColor = Color.Black;
            btcargar.Cursor = Cursors.Hand;
            btcargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btcargar.ForeColor = SystemColors.Control;
            btcargar.Location = new Point(133, 119);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 1;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = false;
            btcargar.Click += btcargar_Click;
            // 
            // txcnombreCarga
            // 
            txcnombreCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txcnombreCarga.Location = new Point(258, 121);
            txcnombreCarga.Name = "txcnombreCarga";
            txcnombreCarga.Size = new Size(125, 27);
            txcnombreCarga.TabIndex = 2;
            // 
            // labellista
            // 
            labellista.AutoSize = true;
            labellista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labellista.ForeColor = SystemColors.Control;
            labellista.Location = new Point(541, 128);
            labellista.Name = "labellista";
            labellista.Size = new Size(51, 20);
            labellista.TabIndex = 3;
            labellista.Text = "label1";
            // 
            // btmostrar
            // 
            btmostrar.BackColor = Color.Black;
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btmostrar.ForeColor = SystemColors.Control;
            btmostrar.Location = new Point(133, 154);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 4;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = false;
            btmostrar.Click += btmostrar_Click;
            // 
            // btlimpiar
            // 
            btlimpiar.BackColor = Color.Black;
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btlimpiar.ForeColor = SystemColors.Control;
            btlimpiar.Location = new Point(133, 189);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(94, 29);
            btlimpiar.TabIndex = 5;
            btlimpiar.Text = "Limpiar";
            btlimpiar.UseVisualStyleBackColor = false;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // RepasoLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1023, 458);
            Controls.Add(btlimpiar);
            Controls.Add(btmostrar);
            Controls.Add(labellista);
            Controls.Add(txcnombreCarga);
            Controls.Add(btcargar);
            Controls.Add(btsalir);
            Name = "RepasoLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RepasoLista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btcargar;
        private TextBox txcnombreCarga;
        private Label labellista;
        private Button btmostrar;
        private Button btlimpiar;
    }
}