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
            btSalir = new Button();
            BtIniciar = new Button();
            SuspendLayout();
            // 
            // btSalir
            // 
            btSalir.Location = new Point(658, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(130, 48);
            btSalir.TabIndex = 0;
            btSalir.Text = "salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // BtIniciar
            // 
            BtIniciar.Location = new Point(658, 77);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(130, 43);
            BtIniciar.TabIndex = 1;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // DoWhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtIniciar);
            Controls.Add(btSalir);
            Name = "DoWhile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoWhile";
            ResumeLayout(false);
        }

        #endregion

        private Button btSalir;
        private Button BtIniciar;
    }
}