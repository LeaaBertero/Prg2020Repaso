namespace While_mientras_
{
    partial class While_Mientras_
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
            BtDoWhile = new Button();
            btSalir = new Button();
            btacomodar = new Button();
            lbazul = new Label();
            lbrojo = new Label();
            btMover = new Button();
            SuspendLayout();
            // 
            // BtDoWhile
            // 
            BtDoWhile.Location = new Point(337, 29);
            BtDoWhile.Name = "BtDoWhile";
            BtDoWhile.Size = new Size(117, 35);
            BtDoWhile.TabIndex = 0;
            BtDoWhile.Text = "DoWhile";
            BtDoWhile.UseVisualStyleBackColor = true;
            BtDoWhile.Click += BtDoWhile_Click;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(694, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 1;
            btSalir.Text = "salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btacomodar
            // 
            btacomodar.Location = new Point(202, 32);
            btacomodar.Name = "btacomodar";
            btacomodar.Size = new Size(94, 29);
            btacomodar.TabIndex = 2;
            btacomodar.Text = "acomodar";
            btacomodar.UseVisualStyleBackColor = true;
            btacomodar.Click += btacomodar_Click;
            // 
            // lbazul
            // 
            lbazul.BackColor = Color.Blue;
            lbazul.Location = new Point(739, 62);
            lbazul.Name = "lbazul";
            lbazul.Size = new Size(49, 81);
            lbazul.TabIndex = 3;
            lbazul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbrojo
            // 
            lbrojo.BackColor = Color.Red;
            lbrojo.Location = new Point(61, 156);
            lbrojo.Name = "lbrojo";
            lbrojo.Size = new Size(121, 41);
            lbrojo.TabIndex = 4;
            lbrojo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btMover
            // 
            btMover.Location = new Point(476, 32);
            btMover.Name = "btMover";
            btMover.Size = new Size(94, 29);
            btMover.TabIndex = 5;
            btMover.Text = "Mover";
            btMover.UseVisualStyleBackColor = true;
            btMover.Click += btMover_Click;
            // 
            // While_Mientras_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 262);
            Controls.Add(btMover);
            Controls.Add(lbrojo);
            Controls.Add(lbazul);
            Controls.Add(btacomodar);
            Controls.Add(btSalir);
            Controls.Add(BtDoWhile);
            Name = "While_Mientras_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "While_Mientras_";
            ResumeLayout(false);
        }

        #endregion

        private Button BtDoWhile;
        private Button btSalir;
        private Button btacomodar;
        private Label lbazul;
        private Label lbrojo;
        private Button btMover;
    }
}