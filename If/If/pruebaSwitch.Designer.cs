namespace If
{
    partial class pruebaSwitch
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
            btsalirSwitch = new Button();
            biiniciarSwitch = new Button();
            lbresSwitch = new Label();
            txnum1 = new TextBox();
            txoperador = new TextBox();
            txnum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btsalirSwitch
            // 
            btsalirSwitch.Location = new Point(330, 398);
            btsalirSwitch.Name = "btsalirSwitch";
            btsalirSwitch.Size = new Size(108, 29);
            btsalirSwitch.TabIndex = 0;
            btsalirSwitch.Text = "salir";
            btsalirSwitch.UseVisualStyleBackColor = true;
            btsalirSwitch.Click += btsalirSwitch_Click;
            // 
            // biiniciarSwitch
            // 
            biiniciarSwitch.Location = new Point(494, 189);
            biiniciarSwitch.Name = "biiniciarSwitch";
            biiniciarSwitch.Size = new Size(102, 32);
            biiniciarSwitch.TabIndex = 1;
            biiniciarSwitch.Text = "Iniciar";
            biiniciarSwitch.UseVisualStyleBackColor = true;
            biiniciarSwitch.Click += biiniciarSwitch_Click;
            // 
            // lbresSwitch
            // 
            lbresSwitch.AutoSize = true;
            lbresSwitch.Font = new Font("Segoe UI", 12F);
            lbresSwitch.Location = new Point(656, 189);
            lbresSwitch.Name = "lbresSwitch";
            lbresSwitch.Size = new Size(65, 28);
            lbresSwitch.TabIndex = 2;
            lbresSwitch.Text = "label1";
            // 
            // txnum1
            // 
            txnum1.Location = new Point(129, 189);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(85, 27);
            txnum1.TabIndex = 3;
            // 
            // txoperador
            // 
            txoperador.Location = new Point(248, 189);
            txoperador.Name = "txoperador";
            txoperador.Size = new Size(85, 27);
            txoperador.TabIndex = 4;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(369, 189);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(85, 27);
            txnum2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 136);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 136);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 136);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "operador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(238, 34);
            label4.Name = "label4";
            label4.Size = new Size(295, 37);
            label4.TabIndex = 9;
            label4.Text = "proyecto proeba switch";
            // 
            // pruebaSwitch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txnum2);
            Controls.Add(txoperador);
            Controls.Add(txnum1);
            Controls.Add(lbresSwitch);
            Controls.Add(biiniciarSwitch);
            Controls.Add(btsalirSwitch);
            Cursor = Cursors.Hand;
            Name = "pruebaSwitch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaSwitch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalirSwitch;
        private Button biiniciarSwitch;
        private Label lbresSwitch;
        private TextBox txnum1;
        private TextBox txoperador;
        private TextBox txnum2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}