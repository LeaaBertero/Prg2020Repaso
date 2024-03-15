namespace borrarRepaso
{
    partial class pruebaBorrar
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
            txcargar = new TextBox();
            lbresultado = new Label();
            label2 = new Label();
            btdimensionar = new Button();
            txDimensionar = new TextBox();
            btsalir = new Button();
            btmostrar = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(91, 185);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(100, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txcargar
            // 
            txcargar.Location = new Point(264, 186);
            txcargar.Name = "txcargar";
            txcargar.Size = new Size(125, 27);
            txcargar.TabIndex = 1;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(526, 194);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(50, 20);
            lbresultado.TabIndex = 2;
            lbresultado.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 29);
            label2.Name = "label2";
            label2.Size = new Size(341, 39);
            label2.TabIndex = 3;
            label2.Text = "Matrices - prueba";
            // 
            // btdimensionar
            // 
            btdimensionar.Location = new Point(91, 150);
            btdimensionar.Name = "btdimensionar";
            btdimensionar.Size = new Size(100, 29);
            btdimensionar.TabIndex = 4;
            btdimensionar.Text = "Dimensionar";
            btdimensionar.UseVisualStyleBackColor = true;
            btdimensionar.Click += btdimensionar_Click;
            // 
            // txDimensionar
            // 
            txDimensionar.Location = new Point(264, 150);
            txDimensionar.Name = "txDimensionar";
            txDimensionar.Size = new Size(125, 27);
            txDimensionar.TabIndex = 5;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(776, 419);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(100, 29);
            btsalir.TabIndex = 6;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btmostrar
            // 
            btmostrar.Location = new Point(91, 220);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(100, 29);
            btmostrar.TabIndex = 7;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // pruebaBorrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(888, 460);
            Controls.Add(btmostrar);
            Controls.Add(btsalir);
            Controls.Add(txDimensionar);
            Controls.Add(btdimensionar);
            Controls.Add(label2);
            Controls.Add(lbresultado);
            Controls.Add(txcargar);
            Controls.Add(btcargar);
            MaximizeBox = false;
            Name = "pruebaBorrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaBorrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txcargar;
        private Label lbresultado;
        private Label label2;
        private Button btdimensionar;
        private TextBox txDimensionar;
        private Button btsalir;
        private Button btmostrar;
    }
}