namespace HolaMundo
{
    partial class HolaMundo
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
            btcargar = new Button();
            txnombre = new TextBox();
            txedad = new TextBox();
            lbLista = new Label();
            label2 = new Label();
            label3 = new Label();
            btsalir = new Button();
            label1 = new Label();
            txdocumento = new TextBox();
            btmostrar = new Button();
            btlimpiar = new Button();
            label4 = new Label();
            txaltura = new TextBox();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.BackColor = Color.Black;
            btcargar.Cursor = Cursors.Hand;
            btcargar.ForeColor = SystemColors.Control;
            btcargar.Location = new Point(56, 129);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 4;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = false;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(222, 131);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // txedad
            // 
            txedad.Location = new Point(597, 138);
            txedad.Name = "txedad";
            txedad.Size = new Size(125, 27);
            txedad.TabIndex = 3;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.ForeColor = SystemColors.Control;
            lbLista.Location = new Point(400, 228);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 3;
            lbLista.Text = "label1";
            lbLista.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(222, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(597, 87);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.Black;
            btsalir.Cursor = Cursors.Hand;
            btsalir.ForeColor = SystemColors.Control;
            btsalir.Location = new Point(893, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 6;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(400, 87);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 8;
            label1.Text = "Documento";
            // 
            // txdocumento
            // 
            txdocumento.Location = new Point(400, 135);
            txdocumento.Name = "txdocumento";
            txdocumento.Size = new Size(125, 27);
            txdocumento.TabIndex = 2;
            // 
            // btmostrar
            // 
            btmostrar.BackColor = Color.Black;
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.ForeColor = SystemColors.Control;
            btmostrar.Location = new Point(56, 164);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 5;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = false;
            btmostrar.Click += btmostrar_Click;
            // 
            // btlimpiar
            // 
            btlimpiar.BackColor = Color.Black;
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.ForeColor = SystemColors.Control;
            btlimpiar.Location = new Point(56, 199);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(94, 29);
            btlimpiar.TabIndex = 9;
            btlimpiar.Text = "Limpiar";
            btlimpiar.UseVisualStyleBackColor = false;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(789, 87);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 11;
            label4.Text = "Altura";
            // 
            // txaltura
            // 
            txaltura.Location = new Point(789, 138);
            txaltura.Name = "txaltura";
            txaltura.Size = new Size(125, 27);
            txaltura.TabIndex = 4;
            // 
            // HolaMundo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(999, 450);
            Controls.Add(label4);
            Controls.Add(txaltura);
            Controls.Add(btlimpiar);
            Controls.Add(btmostrar);
            Controls.Add(label1);
            Controls.Add(txdocumento);
            Controls.Add(btsalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbLista);
            Controls.Add(txedad);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "HolaMundo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HolaMundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private TextBox txedad;
        private Label lbLista;
        private Label label2;
        private Label label3;
        private Button btsalir;
        private Label label1;
        private TextBox txdocumento;
        private Button btmostrar;
        private Button btlimpiar;
        private Label label4;
        private TextBox txaltura;
    }
}