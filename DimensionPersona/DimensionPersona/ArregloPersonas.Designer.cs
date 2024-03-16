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
            btborrar = new Button();
            btFiltrar = new Button();
            Btbuscar = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(288, 145);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 27);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(146, 145);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // lblista
            // 
            lblista.AutoSize = true;
            lblista.Location = new Point(694, 145);
            lblista.Name = "lblista";
            lblista.Size = new Size(50, 20);
            lblista.TabIndex = 2;
            lblista.Text = "label1";
            // 
            // btmostrar
            // 
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.Location = new Point(388, 145);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 27);
            btmostrar.TabIndex = 3;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // txaño
            // 
            txaño.Location = new Point(146, 178);
            txaño.Name = "txaño";
            txaño.Size = new Size(125, 27);
            txaño.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 148);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 181);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 6;
            label2.Text = "Año";
            // 
            // btOperaciones
            // 
            btOperaciones.Cursor = Cursors.Hand;
            btOperaciones.Location = new Point(10, 6);
            btOperaciones.Name = "btOperaciones";
            btOperaciones.Size = new Size(108, 35);
            btOperaciones.TabIndex = 7;
            btOperaciones.Text = "Calculadora";
            btOperaciones.UseVisualStyleBackColor = true;
            btOperaciones.Click += btOperaciones_Click;
            // 
            // btcerrar
            // 
            btcerrar.Cursor = Cursors.Hand;
            btcerrar.Location = new Point(835, 12);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 8;
            btcerrar.Text = "Cerrar";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // btborrar
            // 
            btborrar.Cursor = Cursors.Hand;
            btborrar.Location = new Point(288, 178);
            btborrar.Name = "btborrar";
            btborrar.Size = new Size(94, 27);
            btborrar.TabIndex = 13;
            btborrar.Text = "Borrar";
            btborrar.UseVisualStyleBackColor = true;
            // 
            // btFiltrar
            // 
            btFiltrar.Cursor = Cursors.Hand;
            btFiltrar.Location = new Point(388, 178);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(94, 27);
            btFiltrar.TabIndex = 14;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = true;
            btFiltrar.Click += btFiltrar_Click;
            // 
            // Btbuscar
            // 
            Btbuscar.Cursor = Cursors.Hand;
            Btbuscar.Location = new Point(488, 145);
            Btbuscar.Name = "Btbuscar";
            Btbuscar.Size = new Size(94, 27);
            Btbuscar.TabIndex = 15;
            Btbuscar.Text = "Buscar";
            Btbuscar.UseVisualStyleBackColor = true;
            // 
            // ArregloPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(941, 464);
            Controls.Add(Btbuscar);
            Controls.Add(btFiltrar);
            Controls.Add(btborrar);
            Controls.Add(btcerrar);
            Controls.Add(btOperaciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txaño);
            Controls.Add(btmostrar);
            Controls.Add(lblista);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            MaximizeBox = false;
            Name = "ArregloPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Lista de personas";
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
        private Button btborrar;
        private Button btFiltrar;
        private Button Btbuscar;
    }
}
