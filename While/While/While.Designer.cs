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
            btiniciar = new Button();
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Cursor = Cursors.Hand;
            btejecutar.Location = new Point(266, 12);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(345, 44);
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
            lblRojo.Size = new Size(101, 43);
            lblRojo.TabIndex = 2;
            // 
            // btiniciar
            // 
            btiniciar.Cursor = Cursors.Hand;
            btiniciar.Location = new Point(12, 183);
            btiniciar.Name = "btiniciar";
            btiniciar.Size = new Size(177, 44);
            btiniciar.TabIndex = 3;
            btiniciar.Text = "Mover rectangulo rojo";
            btiniciar.UseVisualStyleBackColor = true;
            btiniciar.Click += btiniciar_Click;
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(btiniciar);
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
        private Button btiniciar;
    }
}