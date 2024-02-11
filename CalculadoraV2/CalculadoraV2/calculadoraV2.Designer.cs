namespace CalculadoraV2
{
    partial class calculadoraV2
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
            btsuma = new Button();
            btresta = new Button();
            btmult = new Button();
            btdivision = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(704, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btsuma
            // 
            btsuma.Location = new Point(100, 160);
            btsuma.Name = "btsuma";
            btsuma.Size = new Size(94, 29);
            btsuma.TabIndex = 1;
            btsuma.Text = "suma";
            btsuma.UseVisualStyleBackColor = true;
            btsuma.Click += btsuma_Click;
            // 
            // btresta
            // 
            btresta.Location = new Point(261, 160);
            btresta.Name = "btresta";
            btresta.Size = new Size(94, 29);
            btresta.TabIndex = 2;
            btresta.Text = "resta";
            btresta.UseVisualStyleBackColor = true;
            btresta.Click += btresta_Click;
            // 
            // btmult
            // 
            btmult.Location = new Point(418, 160);
            btmult.Name = "btmult";
            btmult.Size = new Size(129, 29);
            btmult.TabIndex = 3;
            btmult.Text = "multiplicacion";
            btmult.UseVisualStyleBackColor = true;
            btmult.Click += btmult_Click;
            // 
            // btdivision
            // 
            btdivision.Location = new Point(611, 160);
            btdivision.Name = "btdivision";
            btdivision.Size = new Size(114, 29);
            btdivision.TabIndex = 4;
            btdivision.Text = "división";
            btdivision.UseVisualStyleBackColor = true;
            btdivision.Click += btdivision_Click;
            // 
            // calculadoraV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 290);
            Controls.Add(btdivision);
            Controls.Add(btmult);
            Controls.Add(btresta);
            Controls.Add(btsuma);
            Controls.Add(btsalir);
            Name = "calculadoraV2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculadoraV2";
            ResumeLayout(false);
        }

        #endregion

        private Button btsalir;
        private Button btsuma;
        private Button btresta;
        private Button btmult;
        private Button btdivision;
    }
}