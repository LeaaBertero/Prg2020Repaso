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
            btFiltrar = new Button();
            btbuscar = new Button();
            txCodigo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btBorrar = new Button();
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
            lblista.BackColor = Color.DarkGray;
            lblista.Font = new Font("Segoe UI", 10F);
            lblista.ForeColor = SystemColors.Control;
            lblista.Location = new Point(733, 141);
            lblista.Name = "lblista";
            lblista.Padding = new Padding(10);
            lblista.Size = new Size(20, 43);
            lblista.TabIndex = 2;
            lblista.Visible = false;
            // 
            // btmostrar
            // 
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.Enabled = false;
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
            txaño.Size = new Size(70, 27);
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
            btcerrar.Location = new Point(946, 6);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 8;
            btcerrar.Text = "Salir";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // btFiltrar
            // 
            btFiltrar.Cursor = Cursors.Hand;
            btFiltrar.Location = new Point(488, 145);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(94, 27);
            btFiltrar.TabIndex = 14;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = true;
            btFiltrar.Click += btFiltrar_Click;
            // 
            // btbuscar
            // 
            btbuscar.Cursor = Cursors.Hand;
            btbuscar.Location = new Point(196, 258);
            btbuscar.Name = "btbuscar";
            btbuscar.Size = new Size(94, 27);
            btbuscar.TabIndex = 15;
            btbuscar.Text = "Buscar";
            btbuscar.UseVisualStyleBackColor = true;
            btbuscar.Click += btbuscar_Click;
            // 
            // txCodigo
            // 
            txCodigo.Location = new Point(54, 258);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(125, 27);
            txCodigo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 235);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 17;
            label3.Text = "Ingrese código de búsqueda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOrange;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(282, 33);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(492, 57);
            label4.TabIndex = 18;
            label4.Text = "Proyecto --> Carga de personas <--";
            // 
            // btBorrar
            // 
            btBorrar.Cursor = Cursors.Hand;
            btBorrar.Location = new Point(288, 181);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(94, 27);
            btBorrar.TabIndex = 19;
            btBorrar.Text = "Borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // ArregloPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1052, 464);
            Controls.Add(btBorrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txCodigo);
            Controls.Add(btbuscar);
            Controls.Add(btFiltrar);
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
        private Button btFiltrar;
        private Button btbuscar;
        private TextBox txCodigo;
        private Label label3;
        private Label label4;
        private Button btBorrar;
    }
}
