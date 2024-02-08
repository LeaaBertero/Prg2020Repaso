namespace While
{
    partial class While
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
            btejecutar = new Button();
            btsalir = new Button();
            lblRojo = new Label();
            btnRojo = new Button();
            btnAzul = new Button();
            lbAzul = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Cursor = Cursors.Hand;
            btejecutar.Location = new Point(205, 357);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(446, 44);
            btejecutar.TabIndex = 0;
            btejecutar.Text = "Ejemplo DoWhile";
            btejecutar.UseVisualStyleBackColor = true;
            btejecutar.Click += btejecutar_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(764, 400);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(118, 38);
            btsalir.TabIndex = 1;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // lblRojo
            // 
            lblRojo.BackColor = Color.Red;
            lblRojo.Cursor = Cursors.Hand;
            lblRojo.Location = new Point(-1, 109);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(101, 97);
            lblRojo.TabIndex = 2;
            lblRojo.Click += lblRojo_Click;
            // 
            // btnRojo
            // 
            btnRojo.BackColor = Color.SlateGray;
            btnRojo.Font = new Font("Segoe UI", 12F);
            btnRojo.ForeColor = Color.White;
            btnRojo.Location = new Point(205, 248);
            btnRojo.Name = "btnRojo";
            btnRojo.Size = new Size(170, 54);
            btnRojo.TabIndex = 3;
            btnRojo.Text = "Cuadrado rojo";
            btnRojo.UseVisualStyleBackColor = false;
            btnRojo.Click += btnRojo_Click;
            // 
            // btnAzul
            // 
            btnAzul.BackColor = Color.SlateGray;
            btnAzul.Font = new Font("Segoe UI", 12F);
            btnAzul.ForeColor = Color.White;
            btnAzul.Location = new Point(481, 248);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(170, 54);
            btnAzul.TabIndex = 4;
            btnAzul.Text = "Cuadrado azul";
            btnAzul.UseVisualStyleBackColor = false;
            btnAzul.Click += btnAzul_Click;
            // 
            // lbAzul
            // 
            lbAzul.BackColor = Color.Blue;
            lbAzul.Cursor = Cursors.Hand;
            lbAzul.Location = new Point(781, 109);
            lbAzul.Name = "lbAzul";
            lbAzul.Size = new Size(101, 97);
            lbAzul.TabIndex = 5;
            lbAzul.Click += lbAzul_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 33);
            label1.Name = "label1";
            label1.Size = new Size(498, 33);
            label1.TabIndex = 6;
            label1.Text = "Movimiento de rectángulos";
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(894, 450);
            Controls.Add(label1);
            Controls.Add(lbAzul);
            Controls.Add(btnAzul);
            Controls.Add(btnRojo);
            Controls.Add(btsalir);
            Controls.Add(btejecutar);
            Controls.Add(lblRojo);
            Name = "While";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "While";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btejecutar;
        private Button btsalir;
        private Label lblRojo;
        private Button btnRojo;
        private Button btnAzul;
        private Label lbAzul;
        private Label label1;
    }
}