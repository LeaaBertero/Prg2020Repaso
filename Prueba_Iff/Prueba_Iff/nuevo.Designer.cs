namespace Prueba_Iff
{
    partial class Nuevo
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
            btnuevo = new Button();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btnuevo
            // 
            btnuevo.Location = new Point(392, 137);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(166, 64);
            btnuevo.TabIndex = 0;
            btnuevo.Text = "nuevo formulario";
            btnuevo.UseVisualStyleBackColor = true;
            btnuevo.Click += btnuevo_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(598, 372);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(142, 50);
            btsalir.TabIndex = 1;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // Nuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir);
            Controls.Add(btnuevo);
            Name = "Nuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "nuevo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnuevo;
        private Button btsalir;
    }
}