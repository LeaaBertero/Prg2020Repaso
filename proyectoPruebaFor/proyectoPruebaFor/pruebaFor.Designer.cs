namespace proyectoPruebaFor
{
    partial class pruebaFor
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
            btarranque = new Button();
            lbVerde = new Label();
            btsalir = new Button();
            btiniciar = new Button();
            btvolver = new Button();
            SuspendLayout();
            // 
            // btarranque
            // 
            btarranque.BackColor = Color.Black;
            btarranque.Cursor = Cursors.Hand;
            btarranque.Font = new Font("Jokerman", 12F, FontStyle.Bold);
            btarranque.ForeColor = SystemColors.Control;
            btarranque.Location = new Point(12, 360);
            btarranque.Name = "btarranque";
            btarranque.Size = new Size(166, 55);
            btarranque.TabIndex = 0;
            btarranque.Text = "arrancar";
            btarranque.UseVisualStyleBackColor = false;
            btarranque.Click += btarranque_Click;
            // 
            // lbVerde
            // 
            lbVerde.BackColor = Color.LimeGreen;
            lbVerde.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbVerde.ForeColor = Color.White;
            lbVerde.Location = new Point(12, 129);
            lbVerde.Name = "lbVerde";
            lbVerde.Size = new Size(144, 137);
            lbVerde.TabIndex = 2;
            lbVerde.Text = "Lean";
            lbVerde.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.White;
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Jokerman", 12F, FontStyle.Bold);
            btsalir.ForeColor = Color.Black;
            btsalir.Location = new Point(895, 535);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(166, 55);
            btsalir.TabIndex = 3;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // btiniciar
            // 
            btiniciar.BackColor = Color.Black;
            btiniciar.Cursor = Cursors.Hand;
            btiniciar.Font = new Font("Jokerman", 12F, FontStyle.Bold);
            btiniciar.ForeColor = SystemColors.Control;
            btiniciar.Location = new Point(444, 360);
            btiniciar.Name = "btiniciar";
            btiniciar.Size = new Size(166, 55);
            btiniciar.TabIndex = 4;
            btiniciar.Text = "iniciar";
            btiniciar.UseVisualStyleBackColor = false;
            btiniciar.Click += btiniciar_Click;
            // 
            // btvolver
            // 
            btvolver.BackColor = Color.Black;
            btvolver.Cursor = Cursors.Hand;
            btvolver.Font = new Font("Jokerman", 12F, FontStyle.Bold);
            btvolver.ForeColor = SystemColors.Control;
            btvolver.Location = new Point(895, 360);
            btvolver.Name = "btvolver";
            btvolver.Size = new Size(166, 55);
            btvolver.TabIndex = 5;
            btvolver.Text = "Volver";
            btvolver.UseVisualStyleBackColor = false;
            btvolver.Click += btvolver_Click;
            // 
            // pruebaFor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1073, 602);
            Controls.Add(btvolver);
            Controls.Add(lbVerde);
            Controls.Add(btiniciar);
            Controls.Add(btsalir);
            Controls.Add(btarranque);
            Name = "pruebaFor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaFor";
            ResumeLayout(false);
        }

        #endregion

        private Button btarranque;
        private Label lbVerde;
        private Button btsalir;
        private Button btiniciar;
        private Button btvolver;
    }
}