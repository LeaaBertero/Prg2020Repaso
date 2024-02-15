namespace prueba02
{
    partial class prueba02
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
            btsuma = new Button();
            btresta = new Button();
            btmult = new Button();
            btdiv = new Button();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btsuma
            // 
            btsuma.Cursor = Cursors.Hand;
            btsuma.Location = new Point(105, 125);
            btsuma.Name = "btsuma";
            btsuma.Size = new Size(94, 29);
            btsuma.TabIndex = 0;
            btsuma.Text = "Suma";
            btsuma.UseVisualStyleBackColor = true;
            btsuma.Click += btsuma_Click;
            // 
            // btresta
            // 
            btresta.Cursor = Cursors.Hand;
            btresta.Location = new Point(240, 125);
            btresta.Name = "btresta";
            btresta.Size = new Size(94, 29);
            btresta.TabIndex = 1;
            btresta.Text = "Resta";
            btresta.UseVisualStyleBackColor = true;
            btresta.Click += btresta_Click;
            // 
            // btmult
            // 
            btmult.Cursor = Cursors.Hand;
            btmult.Location = new Point(390, 125);
            btmult.Name = "btmult";
            btmult.Size = new Size(125, 29);
            btmult.TabIndex = 2;
            btmult.Text = "Multiplicación";
            btmult.UseVisualStyleBackColor = true;
            btmult.Click += btmult_Click;
            // 
            // btdiv
            // 
            btdiv.Cursor = Cursors.Hand;
            btdiv.Location = new Point(572, 125);
            btdiv.Name = "btdiv";
            btdiv.Size = new Size(94, 29);
            btdiv.TabIndex = 3;
            btdiv.Text = "División";
            btdiv.UseVisualStyleBackColor = true;
            btdiv.Click += btdiv_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 4;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // prueba02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            Controls.Add(btsalir);
            Controls.Add(btdiv);
            Controls.Add(btmult);
            Controls.Add(btresta);
            Controls.Add(btsuma);
            Name = "prueba02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba02";
            ResumeLayout(false);
        }

        #endregion

        private Button btsuma;
        private Button btresta;
        private Button btmult;
        private Button btdiv;
        private Button btsalir;
    }
}