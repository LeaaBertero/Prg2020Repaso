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
            // DoWhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(Btsalir);
            Name = "DoWhile";
            Text = "DoWhile";
            ResumeLayout(false);
        }

        #endregion

        private Button Btsalir;
    }
}