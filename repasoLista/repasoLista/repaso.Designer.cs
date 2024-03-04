namespace repasoLista
{
    partial class repaso
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
            lbLista = new Label();
            txedad = new TextBox();
            txmostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(114, 92);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(244, 92);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(130, 27);
            txnombre.TabIndex = 1;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.ForeColor = SystemColors.Control;
            lbLista.Location = new Point(639, 97);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 3;
            lbLista.Text = "label1";
            lbLista.Visible = false;
            // 
            // txedad
            // 
            txedad.Location = new Point(410, 92);
            txedad.Name = "txedad";
            txedad.Size = new Size(130, 27);
            txedad.TabIndex = 2;
            // 
            // txmostrar
            // 
            txmostrar.Cursor = Cursors.Hand;
            txmostrar.Location = new Point(114, 164);
            txmostrar.Name = "txmostrar";
            txmostrar.Size = new Size(94, 29);
            txmostrar.TabIndex = 4;
            txmostrar.Text = "Mostrar";
            txmostrar.UseVisualStyleBackColor = true;
            txmostrar.Click += txmostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(244, 69);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(410, 69);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 6;
            label2.Text = "Año de nacimiento";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(779, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 7;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // repaso
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(885, 450);
            Controls.Add(btsalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txmostrar);
            Controls.Add(txedad);
            Controls.Add(lbLista);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "repaso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "repaso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private Label lbLista;
        private TextBox txedad;
        private Button txmostrar;
        private Label label1;
        private Label label2;
        private Button btsalir;
    }
}