namespace DimensionPersona
{
    partial class ArregloPersonas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btcargar = new Button();
            txnombre = new TextBox();
            lblista = new Label();
            btmostrar = new Button();
            txaño = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btOperaciones = new Button();
            btcerrar = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(24, 71);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(196, 73);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // lblista
            // 
            lblista.AutoSize = true;
            lblista.Location = new Point(520, 76);
            lblista.Name = "lblista";
            lblista.Size = new Size(50, 20);
            lblista.TabIndex = 2;
            lblista.Text = "label1";
            // 
            // btmostrar
            // 
            btmostrar.Location = new Point(24, 106);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 3;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // txaño
            // 
            txaño.Location = new Point(336, 73);
            txaño.Name = "txaño";
            txaño.Size = new Size(89, 27);
            txaño.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 36);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 6;
            label2.Text = "Año";
            // 
            // btOperaciones
            // 
            btOperaciones.Location = new Point(716, 306);
            btOperaciones.Name = "btOperaciones";
            btOperaciones.Size = new Size(121, 39);
            btOperaciones.TabIndex = 7;
            btOperaciones.Text = "Calculadora";
            btOperaciones.UseVisualStyleBackColor = true;
            btOperaciones.Click += btOperaciones_Click;
            // 
            // btcerrar
            // 
            btcerrar.Location = new Point(743, 12);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 8;
            btcerrar.Text = "Cerrar";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // ArregloPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 357);
            Controls.Add(btcerrar);
            Controls.Add(btOperaciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txaño);
            Controls.Add(btmostrar);
            Controls.Add(lblista);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "ArregloPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private Label lblista;
        private Button btmostrar;
        private TextBox txaño;
        private Label label1;
        private Label label2;
        private Button btOperaciones;
        private Button btcerrar;
    }
}
