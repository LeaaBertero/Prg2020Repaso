namespace ArraysV2
{
    partial class ArreglosV2
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
            txNombre = new TextBox();
            btcargar = new Button();
            btmostrar = new Button();
            btDimensionar = new Button();
            txDimensionar = new TextBox();
            label1 = new Label();
            lbLista = new Label();
            SuspendLayout();
            // 
            // txNombre
            // 
            txNombre.Location = new Point(219, 99);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 0;
            // 
            // btcargar
            // 
            btcargar.Location = new Point(75, 99);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 1;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // btmostrar
            // 
            btmostrar.Location = new Point(74, 134);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 2;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // btDimensionar
            // 
            btDimensionar.Location = new Point(75, 64);
            btDimensionar.Name = "btDimensionar";
            btDimensionar.Size = new Size(108, 29);
            btDimensionar.TabIndex = 3;
            btDimensionar.Text = "Dimensionar";
            btDimensionar.UseVisualStyleBackColor = true;
            btDimensionar.Click += btDimensionar_Click;
            // 
            // txDimensionar
            // 
            txDimensionar.Location = new Point(219, 66);
            txDimensionar.Name = "txDimensionar";
            txDimensionar.Size = new Size(125, 27);
            txDimensionar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Dimensionar";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(499, 64);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(0, 20);
            lbLista.TabIndex = 6;
            lbLista.Visible = false;
            // 
            // ArreglosV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(lbLista);
            Controls.Add(label1);
            Controls.Add(txDimensionar);
            Controls.Add(btDimensionar);
            Controls.Add(btmostrar);
            Controls.Add(btcargar);
            Controls.Add(txNombre);
            Cursor = Cursors.Hand;
            Name = "ArreglosV2";
            Text = "ArreglosV2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txNombre;
        private Button btcargar;
        private Button btmostrar;
        private Button btDimensionar;
        private TextBox txDimensionar;
        private Label label1;
        private Label lbLista;
    }
}