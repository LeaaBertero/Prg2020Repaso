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
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Cursor = Cursors.Hand;
            btejecutar.Location = new Point(637, 12);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(167, 44);
            btejecutar.TabIndex = 0;
            btejecutar.Text = "Ejemplo DoWhile";
            btejecutar.UseVisualStyleBackColor = true;
            btejecutar.Click += btejecutar_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(670, 400);
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
            // 
            // btnRojo
            // 
            btnRojo.Location = new Point(205, 248);
            btnRojo.Name = "btnRojo";
            btnRojo.Size = new Size(170, 42);
            btnRojo.TabIndex = 3;
            btnRojo.Text = "Cuadrado rojo";
            btnRojo.UseVisualStyleBackColor = true;
            btnRojo.Click += btnRojo_Click;
            // 
            // btnAzul
            // 
            btnAzul.Location = new Point(481, 248);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(170, 42);
            btnAzul.TabIndex = 4;
            btnAzul.Text = "Cuadrado azul";
            btnAzul.UseVisualStyleBackColor = true;
            btnAzul.Click += btnAzul_Click;
            // 
            // lbAzul
            // 
            lbAzul.BackColor = Color.Blue;
            lbAzul.Cursor = Cursors.Hand;
            lbAzul.Location = new Point(703, 109);
            lbAzul.Name = "lbAzul";
            lbAzul.Size = new Size(101, 97);
            lbAzul.TabIndex = 5;
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(816, 450);
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
        }

        #endregion

        private Button btejecutar;
        private Button btsalir;
        private Label lblRojo;
        private Button btnRojo;
        private Button btnAzul;
        private Label lbAzul;
    }
}