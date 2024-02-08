namespace While
{
    partial class DoWhile
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
            Btsalir = new Button();
            btMover = new Button();
            lbBlue = new Label();
            SuspendLayout();
            // 
            // Btsalir
            // 
            Btsalir.Cursor = Cursors.Hand;
            Btsalir.Location = new Point(658, 402);
            Btsalir.Name = "Btsalir";
            Btsalir.Size = new Size(130, 36);
            Btsalir.TabIndex = 0;
            Btsalir.Text = "Salir";
            Btsalir.UseVisualStyleBackColor = true;
            Btsalir.Click += Btsalir_Click;
            // 
            // btMover
            // 
            btMover.Cursor = Cursors.Hand;
            btMover.Location = new Point(12, 302);
            btMover.Name = "btMover";
            btMover.Size = new Size(128, 33);
            btMover.TabIndex = 1;
            btMover.Text = "Mover";
            btMover.UseVisualStyleBackColor = true;
            btMover.Click += btMover_Click;
            // 
            // lbBlue
            // 
            lbBlue.BackColor = Color.Navy;
            lbBlue.Location = new Point(12, 140);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(83, 83);
            lbBlue.TabIndex = 2;
            lbBlue.Text = "label1";
            // 
            // DoWhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(lbBlue);
            Controls.Add(btMover);
            Controls.Add(Btsalir);
            Name = "DoWhile";
            Text = "DoWhile";
            Click += DoWhile_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button Btsalir;
        private Button btMover;
        private Label lbBlue;
    }
}